# Notas importantes

## SqlServerConnectionString

- En appsettings.Development.json tengo los datos básicos de conexión
- El usuario y el password los almaceno en user secrets
    1. Primero creo un elemento nuevo en el XML
    ```xml
    <Project Sdk="Microsoft.NET.Sdk.Web">
        <PropertyGroup>
            <TargetFramework>net6.0</TargetFramework>
            <Nullable>enable</Nullable>
            <ImplicitUsings>enable</ImplicitUsings>
            <UserSecretsId>dff599d7-6db2-48b8-9bf7-62c5f913ad7c</UserSecretsId>
        </PropertyGroup>
        <ItemGroup>
            <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.8" />
            <PackageReference Include="Microsoft.EntityFrameworkCore.InMemory" Version="6.0.8" />
            <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.8" />
        </ItemGroup>
    </Project>
    ```
    2. Añado los user secrets mediante el terminal
    ```bash
        dotnet user-secrets set "UserId" "sa"
        dotnet user-secrets set "Password" "Password12!"
    ```

    3. Para que me funcione la ejecución en linux mint, he de correr la aplicación con:
    ```bash
    dotnet run --arch x64 --os linux
    ```

## Migraciones

- Verificar que tenemos la herramienta de migraciones
```bash
dotnet ef
```

- Si no existe la herramienta se instala
```bash
dotnet tool install --global dotnet-ef
```

- Si queremos actualizar la herramienta de migraciones
```bash
dotnet tool update --global dotnet-ef
```

- Inicializa la migración
```bash

```

- Añade una migración
```bashdot
```

- Actualizar la base de datos con las diferentes migraciones
```bash
```
