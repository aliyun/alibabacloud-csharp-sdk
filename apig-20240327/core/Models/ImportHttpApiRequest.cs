// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ImportHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The API deployment configurations.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The description of the API to import. If omitted, the description is taken from the API definition. The maximum length is 255 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试专用API</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether to perform a dry run. If <c>true</c>, the system validates the request but does not import the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The MCP route ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("mcpRouteId")]
        [Validation(Required=false)]
        public string McpRouteId { get; set; }

        /// <summary>
        /// <para>The name of the API to import. If omitted, the name is taken from the API definition file. If an API with the same name and versioning configuration already exists, the import acts as an update based on the specified <c>strategy</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/151181.html">resource group ID</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek23nsa353vmra</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded API definition. It supports OpenAPI Specification (OAS) 2.0 and 3.0 and can be in either YAML or JSON format. This parameter takes precedence over <c>specFileUrl</c>. If the file size is larger than 10 MB, use the <c>specFileUrl</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3BlbmFwaTogMy4wLjAKaW5mbzoKICAgIHRpdGxlOiBkZW1vCiAgICBkZXNjcmlwdGlvbjogdGhpc2lzZGVtbwogICAgdmVyc2lvbjogIiIKcGF0aHM6CiAgICAvdXNlci97dXNlcklkfToKICAgICAgICBnZXQ6CiAgICAgICAgICAgIHN1bW1hcnk6IOiOt+WPlueUqOaIt+S/oeaBrwogICAgICAgICAgICBkZXNjcmlwdGlvbjog6I635Y+W55So5oi35L+h5oGvCiAgICAgICAgICAgIG9wZXJhdGlvbklkOiBHZXRVc2VySW5mbwogICAgICAgICAgICByZXNwb25zZXM6CiAgICAgICAgICAgICAgICAiMjAwIjoKICAgICAgICAgICAgICAgICAgICBkZXNjcmlwdGlvbjog5oiQ5YqfCiAgICAgICAgICAgICAgICAgICAgY29udGVudDoKICAgICAgICAgICAgICAgICAgICAgICAgYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PXV0Zi04OgogICAgICAgICAgICAgICAgICAgICAgICAgICAgc2NoZW1hOiBudWxsCnNlcnZlcnM6CiAgICAtIHVybDogaHR0cDovL2FwaS5leGFtcGxlLmNvbS92MQo=</para>
        /// </summary>
        [NameInMap("specContentBase64")]
        [Validation(Required=false)]
        public string SpecContentBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the API definition file stored in OSS. The URL must be accessible from the public network or be an internal OSS endpoint in the same region. For OSS objects that are not publicly readable, use a presigned URL. For details, see <a href="https://help.aliyun.com/document_detail/39607.html">Download a file by using a presigned URL</a>.</para>
        /// </summary>
        [NameInMap("specFileUrl")]
        [Validation(Required=false)]
        public string SpecFileUrl { get; set; }

        /// <summary>
        /// <para>Configuration for fetching the API definition from an OSS bucket.</para>
        /// </summary>
        [NameInMap("specOssConfig")]
        [Validation(Required=false)]
        public ImportHttpApiRequestSpecOssConfig SpecOssConfig { get; set; }
        public class ImportHttpApiRequestSpecOssConfig : TeaModel {
            /// <summary>
            /// <para>The name of the OSS bucket that contains the API definition file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gms-service-prod</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The object key (file path) of the API definition file within the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/swagger.json</para>
            /// </summary>
            [NameInMap("objectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The ID of the region where the OSS bucket is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The update strategy to apply when an API with the same name and versioning configuration already exists.</para>
        /// <list type="bullet">
        /// <item><description><para><c>SpecOnly</c>: Overwrites the existing API completely with the imported definition.</para>
        /// </description></item>
        /// <item><description><para><c>SpecFirst</c>: Updates existing APIs and creates new ones based on the imported definition. Existing APIs not included in the import file are unaffected.</para>
        /// </description></item>
        /// <item><description><para><c>ExistFirst</c>: Creates new APIs from the imported definition but does not modify any existing APIs. This is the default strategy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>If you specify this parameter, the import updates the specified API instead of creating a new one or searching for an existing API by name and versioning configuration. The target API must be an HTTP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("targetHttpApiId")]
        [Validation(Required=false)]
        public string TargetHttpApiId { get; set; }

        /// <summary>
        /// <para>The versioning configuration for the API. If an existing API matches the specified name (and version, if enabled), this import updates that API.</para>
        /// </summary>
        [NameInMap("versionConfig")]
        [Validation(Required=false)]
        public HttpApiVersionConfig VersionConfig { get; set; }

        [NameInMap("withGatewayExtension")]
        [Validation(Required=false)]
        public bool? WithGatewayExtension { get; set; }

    }

}
