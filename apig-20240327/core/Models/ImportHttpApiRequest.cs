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
        /// <para>The description of the imported API. If this parameter is not specified, the description is extracted from the API definition. Maximum length: 255 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试专用API</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. If enabled, only validation is performed without the actual import.</para>
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
        /// <para>The name of the imported API. If this parameter is not specified, the name is extracted from the API definition file. If an API with the same name and version configuration already exists, this import updates the existing API definition based on the strategy parameter.</para>
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
        /// <para>The Base64-encoded API definition. OAS 2.0 and OAS 3.0 specifications are supported in YAML or JSON format. This parameter takes priority over the specFileUrl parameter. If the file size exceeds 10 MB, use the specFileUrl parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3BlbmFwaTogMy4wLjAKaW5mbzoKICAgIHRpdGxlOiBkZW1vCiAgICBkZXNjcmlwdGlvbjogdGhpc2lzZGVtbwogICAgdmVyc2lvbjogIiIKcGF0aHM6CiAgICAvdXNlci97dXNlcklkfToKICAgICAgICBnZXQ6CiAgICAgICAgICAgIHN1bW1hcnk6IOiOt+WPlueUqOaIt+S/oeaBrwogICAgICAgICAgICBkZXNjcmlwdGlvbjog6I635Y+W55So5oi35L+h5oGvCiAgICAgICAgICAgIG9wZXJhdGlvbklkOiBHZXRVc2VySW5mbwogICAgICAgICAgICByZXNwb25zZXM6CiAgICAgICAgICAgICAgICAiMjAwIjoKICAgICAgICAgICAgICAgICAgICBkZXNjcmlwdGlvbjog5oiQ5YqfCiAgICAgICAgICAgICAgICAgICAgY29udGVudDoKICAgICAgICAgICAgICAgICAgICAgICAgYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PXV0Zi04OgogICAgICAgICAgICAgICAgICAgICAgICAgICAgc2NoZW1hOiBudWxsCnNlcnZlcnM6CiAgICAtIHVybDogaHR0cDovL2FwaS5leGFtcGxlLmNvbS92MQo=</para>
        /// </summary>
        [NameInMap("specContentBase64")]
        [Validation(Required=false)]
        public string SpecContentBase64 { get; set; }

        /// <summary>
        /// <para>The download URL of the API definition file. The URL must be accessible over the public network or be an internal network OSS download URL in the same region. The URL must have download permissions. For OSS files that are not publicly readable, see References <a href="https://help.aliyun.com/document_detail/39607.html">Download objects using presigned URLs</a> and provide a URL with download permissions. Only API definition files stored in OSS are supported.</para>
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
        /// <para>The update strategy to use when the imported API has the same name and version management configuration as an existing API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SpecOnly: uses the imported file as the single source of truth.</description></item>
        /// <item><description>SpecFirst: prioritizes the imported file. New operations are added and existing operations are updated. Operations not mentioned in the file remain unchanged.</description></item>
        /// <item><description>ExistFirst: prioritizes the existing API. Only new operations are added. Existing operations are not updated.</description></item>
        /// </list>
        /// <para>Default value: ExistFirst.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The ID of the target HTTP API. If this parameter is specified, this import updates the specified API instead of creating a new one or searching for an existing API by name and version management configuration. The target API must be of the REST type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("targetHttpApiId")]
        [Validation(Required=false)]
        public string TargetHttpApiId { get; set; }

        /// <summary>
        /// <para>The API version configuration. If version configuration is enabled and an API with the same version number and name already exists, this import is treated as an update. If version configuration is not enabled and an API with the same name already exists, this import is treated as an update.</para>
        /// </summary>
        [NameInMap("versionConfig")]
        [Validation(Required=false)]
        public HttpApiVersionConfig VersionConfig { get; set; }

        [NameInMap("withGatewayExtension")]
        [Validation(Required=false)]
        public bool? WithGatewayExtension { get; set; }

    }

}
