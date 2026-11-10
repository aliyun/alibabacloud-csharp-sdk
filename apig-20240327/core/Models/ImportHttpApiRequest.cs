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
        /// <para>The description of the API to be imported. If you do not specify this parameter, the description is extracted from the API definition file. The maximum length is 255 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test API</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. If you set this parameter to true, the system only checks the Swagger definition without importing the API.</para>
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
        /// <para>mcp-route-xxxxxxxx</para>
        /// </summary>
        [NameInMap("mcpRouteId")]
        [Validation(Required=false)]
        public string McpRouteId { get; set; }

        /// <summary>
        /// <para>The name of the API to be imported. If you do not specify this parameter, the name is extracted from the API definition file. If an API with the same name and version configuration already exists, the import operation updates the existing API definition based on the strategy parameter.</para>
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
        /// <para>The Base64-encoded API definition. Supports OAS 2.0 and OAS 3.0 specifications in YAML or JSON format. This parameter has a higher priority than the specFileUrl parameter. If the file size exceeds 10 MB, use the specFileUrl parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3BlbmFwaTogMy4wLjAKaW5mbzoKICAgIHRpdGxlOiBkZW1vCiAgICBkZXNjcmlwdGlvbjogdGhpc2lzZGVtbwogICAgdmVyc2lvbjogIiIKcGF0aHM6CiAgICAvdXNlci97dXNlcklkfToKICAgICAgICBnZXQ6CiAgICAgICAgICAgIHN1bW1hcnk6IOiOt+WPlueUqOaIt+S/oeaBrwogICAgICAgICAgICBkZXNjcmlwdGlvbjog6I635Y+W55So5oi35L+h5oGvCiAgICAgICAgICAgIG9wZXJhdGlvbklkOiBHZXRVc2VySW5mbwogICAgICAgICAgICByZXNwb25zZXM6CiAgICAgICAgICAgICAgICAiMjAwIjoKICAgICAgICAgICAgICAgICAgICBkZXNjcmlwdGlvbjog5oiQ5YqfCiAgICAgICAgICAgICAgICAgICAgY29udGVudDoKICAgICAgICAgICAgICAgICAgICAgICAgYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PXV0Zi04OgogICAgICAgICAgICAgICAgICAgICAgICAgICAgc2NoZW1hOiBudWxsCnNlcnZlcnM6CiAgICAtIHVybDogaHR0cDovL2FwaS5leGFtcGxlLmNvbS92MQo=</para>
        /// </summary>
        [NameInMap("specContentBase64")]
        [Validation(Required=false)]
        public string SpecContentBase64 { get; set; }

        /// <summary>
        /// <para>The download URL of the API definition file. The file must be downloadable over the Internet or through the internal network of OSS in the same region. The URL must have download permissions. For OSS file links that are not publicly readable, see References: <a href="https://help.aliyun.com/document_detail/39607.html">Download objects by using presigned URLs</a> and provide a URL with download permissions. Currently, only API definition files stored in OSS are supported.</para>
        /// </summary>
        [NameInMap("specFileUrl")]
        [Validation(Required=false)]
        public string SpecFileUrl { get; set; }

        /// <summary>
        /// <para>The OSS configuration.</para>
        /// </summary>
        [NameInMap("specOssConfig")]
        [Validation(Required=false)]
        public ImportHttpApiRequestSpecOssConfig SpecOssConfig { get; set; }
        public class ImportHttpApiRequestSpecOssConfig : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gms-service-prod</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The full path of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/swagger.json</para>
            /// </summary>
            [NameInMap("objectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The update policy to use when the name and version management configuration of the imported API are the same as those of an existing API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SpecOnly: The imported file completely overwrites the existing API.</description></item>
        /// <item><description>SpecFirst: The imported file takes precedence. New operations are added and existing operations are updated. Operations not mentioned in the file remain unchanged.</description></item>
        /// <item><description>ExistFirst: The existing API takes precedence. Only new operations are added, and existing operations are not updated.
        /// Default value: ExistFirst.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The ID of the HTTP API to be overwritten by the import. If you specify this parameter, the import operation updates the specified API instead of importing a new API or searching for an existing API based on the name and version management configuration. The target API must be of the REST type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("targetHttpApiId")]
        [Validation(Required=false)]
        public string TargetHttpApiId { get; set; }

        /// <summary>
        /// <para>The API versioning configuration. If versioning is enabled and an API with the same name and version number already exists, the import operation is treated as an update. If versioning is disabled and an API with the same name already exists, the import operation is also treated as an update.</para>
        /// </summary>
        [NameInMap("versionConfig")]
        [Validation(Required=false)]
        public HttpApiVersionConfig VersionConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to import gateway extension information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withGatewayExtension")]
        [Validation(Required=false)]
        public bool? WithGatewayExtension { get; set; }

    }

}
