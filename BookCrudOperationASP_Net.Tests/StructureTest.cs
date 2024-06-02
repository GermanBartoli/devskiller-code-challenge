
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace BookCruBookCrudOperationASP_Net.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("Qm9va0NydWRPcGVyYXRpb25BU1BfTmV0LCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("UHJvZ3JhbQ==") /*"Program"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("TWFpbg==") /*"Main"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.Main(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.Main(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.Main(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.Main(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.Main(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.Main(String[] args) parameter args does not exists or does not have type System.String[]");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlV2ViSG9zdEJ1aWxkZXI=") /*"CreateWebHostBuilder"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.CreateWebHostBuilder(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.CreateWebHostBuilder(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.CreateWebHostBuilder(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Hosting.IWebHostBuilder",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.CreateWebHostBuilder(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.CreateWebHostBuilder(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program.CreateWebHostBuilder(String[] args) parameter args does not exists or does not have type System.String[]");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Program() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U3RhcnR1cA==") /*"Startup"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJlU2VydmljZXM=") /*"ConfigureServices"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.ConfigureServices(IServiceCollection services) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.ConfigureServices(IServiceCollection services) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.ConfigureServices(IServiceCollection services) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.ConfigureServices(IServiceCollection services) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZXM=") /*"services"*/  && x.ParameterType.FullName == "Microsoft.Extensions.DependencyInjection.IServiceCollection");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.ConfigureServices(IServiceCollection services) parameter services does not exists or does not have type Microsoft.Extensions.DependencyInjection.IServiceCollection");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJl") /*"Configure"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXBw") /*"app"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter app does not exists or does not have type Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZW52") /*"env"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter env does not exists or does not have type Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("Microsoft.Extensions.Configuration.IConfiguration");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup(IConfiguration configuration) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup(IConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29uZmlndXJhdGlvbg==") /*"configuration"*/  && x.ParameterType.FullName == "Microsoft.Extensions.Configuration.IConfiguration");
                                Assert.IsNotNull(parameter, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup(IConfiguration configuration) parameter configuration does not exists or does not have type Microsoft.Extensions.Configuration.IConfiguration");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJhdGlvbg==") /*"Configuration"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.IConfiguration Configuration does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NvbmZpZ3VyYXRpb24=") /*"get_Configuration"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.get_Configuration() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.get_Configuration() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.get_Configuration() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Startup.IConfiguration Configuration  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("RXJyb3JWaWV3TW9kZWw=") /*"ErrorViewModel"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UmVxdWVzdElk") /*"RequestId"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.String RequestId does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlcXVlc3RJZA==") /*"get_RequestId"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_RequestId() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_RequestId() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_RequestId() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1JlcXVlc3RJZA==") /*"get_RequestId"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_RequestId() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_RequestId() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_RequestId() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.String RequestId  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2hvd1JlcXVlc3RJZA==") /*"ShowRequestId"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.Boolean ShowRequestId does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1Nob3dSZXF1ZXN0SWQ=") /*"get_ShowRequestId"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_ShowRequestId() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_ShowRequestId() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.get_ShowRequestId() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Boolean",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Models.ErrorViewModel.Boolean ShowRequestId  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Qm9vaw==") /*"Book"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SWQ=") /*"Id"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.Int32 Id does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Id() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Id() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.Int32 Id  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("aXNibg==") /*"isbn"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String isbn does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X2lzYm4=") /*"get_isbn"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_isbn() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_isbn() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_isbn() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X2lzYm4=") /*"get_isbn"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_isbn() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_isbn() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_isbn() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String isbn  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VGl0bGU=") /*"Title"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Title does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RpdGxl") /*"get_Title"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Title() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Title() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Title() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RpdGxl") /*"get_Title"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Title() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Title() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Title() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Title  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UHVibGlzaGVy") /*"Publisher"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Publisher does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1B1Ymxpc2hlcg==") /*"get_Publisher"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Publisher() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Publisher() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Publisher() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1B1Ymxpc2hlcg==") /*"get_Publisher"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Publisher() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Publisher() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Publisher() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Publisher  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QXV0aG9y") /*"Author"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Author does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0F1dGhvcg==") /*"get_Author"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Author() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Author() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Author() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0F1dGhvcg==") /*"get_Author"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Author() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Author() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Author() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Author  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("UGFnZXM=") /*"Pages"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Pages does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1BhZ2Vz") /*"get_Pages"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Pages() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Pages() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Pages() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1BhZ2Vz") /*"get_Pages"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Pages() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Pages() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.get_Pages() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.Book.String Pages  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Qm9va0RiQ29udGV4dA==") /*"BookDbContext"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("Microsoft.EntityFrameworkCore.DbContextOptions`1[[BookCrudOperationASP_Net.Data.BookDbContext, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext(DbContextOptions`1 options) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext(DbContextOptions`1 options)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("b3B0aW9ucw==") /*"options"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("Microsoft.EntityFrameworkCore.DbContextOptions`1[[BookCrudOperationASP_Net.Data.BookDbContext"));
                                Assert.IsNotNull(parameter, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext(DbContextOptions`1 options) parameter options does not exists or does not have type Microsoft.EntityFrameworkCore.DbContextOptions`1[[BookCrudOperationASP_Net.Data.BookDbContext, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Qm9va3M=") /*"Books"*/ );
                            Assert.IsNotNull(property, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.DbSet`1 Books does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Jvb2tz") /*"get_Books"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.get_Books() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.get_Books() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BookCrudOperationASP_Net.Data.Book, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.get_Books() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Jvb2tz") /*"get_Books"*/ );                                Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.get_Books() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.get_Books() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BookCrudOperationASP_Net.Data.Book, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.get_Books() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BookCrudOperationASP_Net.Data.Book, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",propertyReturnType.FullName, "property: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookDbContext.DbSet`1 Books  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Qm9va1JlcG9zaXRvcnk=") /*"BookRepository"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0QWxsQm9va3M=") /*"GetAllBooks"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetAllBooks() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetAllBooks() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetAllBooks() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.List`1[[BookCrudOperationASP_Net.Data.Book, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetAllBooks() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0Qm9va0J5SWQ=") /*"GetBookById"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetBookById(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetBookById(Int32 id) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetBookById(Int32 id) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("BookCrudOperationASP_Net.Data.Book",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetBookById(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetBookById(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.GetBookById(Int32 id) parameter id does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("QWRkQm9vaw==") /*"AddBook"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.AddBook(Book book) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.AddBook(Book book) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.AddBook(Book book) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.AddBook(Book book) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.AddBook(Book book) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Ym9vaw==") /*"book"*/  && x.ParameterType.FullName == "BookCrudOperationASP_Net.Data.Book");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.AddBook(Book book) parameter book does not exists or does not have type BookCrudOperationASP_Net.Data.Book");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("VXBkYXRlQm9vaw==") /*"UpdateBook"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.UpdateBook(Book book) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.UpdateBook(Book book) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.UpdateBook(Book book) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.UpdateBook(Book book) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.UpdateBook(Book book) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Ym9vaw==") /*"book"*/  && x.ParameterType.FullName == "BookCrudOperationASP_Net.Data.Book");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.UpdateBook(Book book) parameter book does not exists or does not have type BookCrudOperationASP_Net.Data.Book");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RGVsZXRlQm9vaw==") /*"DeleteBook"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.DeleteBook(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.DeleteBook(Int32 id) is not public");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.DeleteBook(Int32 id) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.DeleteBook(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.DeleteBook(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository.DeleteBook(Int32 id) parameter id does not exists or does not have type System.Int32");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("BookCrudOperationASP_Net.Data.BookDbContext");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository(BookDbContext bookDbContext) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository(BookDbContext bookDbContext)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Ym9va0RiQ29udGV4dA==") /*"bookDbContext"*/  && x.ParameterType.FullName == "BookCrudOperationASP_Net.Data.BookDbContext");
                                Assert.IsNotNull(parameter, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.BookRepository(BookDbContext bookDbContext) parameter bookDbContext does not exists or does not have type BookCrudOperationASP_Net.Data.BookDbContext");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SUJvb2tzUmVwb3NpdG9yeQ==") /*"IBooksRepository"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository");
                    Assert.IsTrue(type.IsAbstract, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0QWxsQm9va3M=") /*"GetAllBooks"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetAllBooks() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetAllBooks() is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetAllBooks() is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetAllBooks() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.List`1[[BookCrudOperationASP_Net.Data.Book, BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetAllBooks() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0Qm9va0J5SWQ=") /*"GetBookById"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("BookCrudOperationASP_Net.Data.Book",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.GetBookById(Int32 id) parameter id does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("QWRkQm9vaw==") /*"AddBook"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Ym9vaw==") /*"book"*/  && x.ParameterType.FullName == "BookCrudOperationASP_Net.Data.Book");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.AddBook(Book book) parameter book does not exists or does not have type BookCrudOperationASP_Net.Data.Book");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("VXBkYXRlQm9vaw==") /*"UpdateBook"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Ym9vaw==") /*"book"*/  && x.ParameterType.FullName == "BookCrudOperationASP_Net.Data.Book");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.UpdateBook(Book book) parameter book does not exists or does not have type BookCrudOperationASP_Net.Data.Book");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RGVsZXRlQm9vaw==") /*"DeleteBook"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Data.IBooksRepository.DeleteBook(Int32 id) parameter id does not exists or does not have type System.Int32");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Qm9va3NDb250cm9sbGVy") /*"BooksController"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController");
                    Assert.IsTrue(type.IsClass, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("SW5kZXg=") /*"Index"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Index() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Index() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Index() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRl") /*"Create"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRl") /*"Create"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create(Book book) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create(Book book) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create(Book book) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Create(Book book) parameters count has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("VXBkYXRl") /*"Update"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 id) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 id) parameter id does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 2).FirstOrDefault(x=>x.Name == Decode("VXBkYXRl") /*"Update"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 idBook objBook) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 idBook objBook) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 idBook objBook) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 idBook objBook) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 idBook objBook) parameter id does not exists or does not have type System.Int32");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Update(Int32 idBook objBook) parameters count has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RGVsZXRl") /*"Delete"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Delete(Int32 id) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Delete(Int32 id) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Delete(Int32 id) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Delete(Int32 id) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aWQ=") /*"id"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Delete(Int32 id) parameter id does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RXJyb3I=") /*"Error"*/ );                            Assert.IsNotNull(method, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Error() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Error() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Mvc.IActionResult",methodReturnType.FullName, "method: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController.Error() return type has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("BookCrudOperationASP_Net.Data.IBooksRepository");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController(IBooksRepository booksRepository) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController(IBooksRepository booksRepository)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Ym9va3NSZXBvc2l0b3J5") /*"booksRepository"*/  && x.ParameterType.FullName == "BookCrudOperationASP_Net.Data.IBooksRepository");
                                Assert.IsNotNull(parameter, "constructor: BookCrudOperationASP_Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookCrudOperationASP_Net.Controllers.BooksController(IBooksRepository booksRepository) parameter booksRepository does not exists or does not have type BookCrudOperationASP_Net.Data.IBooksRepository");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
