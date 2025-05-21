// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ImportHttpApiRequest : TeaModel {
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public HttpApiDeployConfig DeployConfigs { get; set; }

        /// <summary>
        /// <para>The API description, which cannot exceed 255 bytes in length. If you do not specify a description, a description is extracted from the definition file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API for testing</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. If this parameter is set to true, a dry run is performed without importing the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("mcpRouteId")]
        [Validation(Required=false)]
        public string McpRouteId { get; set; }

        /// <summary>
        /// <para>The API name. If you do not specify a name, a name is extracted from the definition file. If a name and a versioning configuration already exist, the existing API definition is updated based on the strategy field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/151181.html">The resource group ID</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3q4zjh7fkki</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded API definition. OAS 2.0 and OAS 3.0 specifications are supported. YAML and JSON formats are supported. This parameter precedes over the specFileUrl parameter. However, if the file size exceeds 10 MB, use the specFileUrl parameter to pass the definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3BlbmFwaTogMy4wLjAKaW5mbzoKICAgIHRpdGxlOiBkZW1vCiAgICBkZXNjcmlwdGlvbjogdGhpc2lzZGVtbwogICAgdmVyc2lvbjogIiIKcGF0aHM6CiAgICAvdXNlci97dXNlcklkfToKICAgICAgICBnZXQ6CiAgICAgICAgICAgIHN1bW1hcnk6IOiOt+WPlueUqOaIt+S/oeaBrwogICAgICAgICAgICBkZXNjcmlwdGlvbjog6I635Y+W55So5oi35L+h5oGvCiAgICAgICAgICAgIG9wZXJhdGlvbklkOiBHZXRVc2VySW5mbwogICAgICAgICAgICByZXNwb25zZXM6CiAgICAgICAgICAgICAgICAiMjAwIjoKICAgICAgICAgICAgICAgICAgICBkZXNjcmlwdGlvbjog5oiQ5YqfCiAgICAgICAgICAgICAgICAgICAgY29udGVudDoKICAgICAgICAgICAgICAgICAgICAgICAgYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PXV0Zi04OgogICAgICAgICAgICAgICAgICAgICAgICAgICAgc2NoZW1hOiBudWxsCnNlcnZlcnM6CiAgICAtIHVybDogaHR0cDovL2FwaS5leGFtcGxlLmNvbS92MQo=</para>
        /// </summary>
        [NameInMap("specContentBase64")]
        [Validation(Required=false)]
        public string SpecContentBase64 { get; set; }

        /// <summary>
        /// <para>The download URL of the API definition file. You can download the file over the Internet or by using an Object Storage Service (OSS) internal download URL that belongs to the current region. You must obtain the required permissions to download the file. For OSS URLs that are not publicly readable, refer to <a href="https://help.aliyun.com/zh/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">https://help.aliyun.com/zh/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects</a> to specify URLs that provide download permissions. Currently, only OSS URLs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/my-api/api.yaml">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/my-api/api.yaml</a></para>
        /// </summary>
        [NameInMap("specFileUrl")]
        [Validation(Required=false)]
        public string SpecFileUrl { get; set; }

        /// <summary>
        /// <para>The OSS information.</para>
        /// </summary>
        [NameInMap("specOssConfig")]
        [Validation(Required=false)]
        public ImportHttpApiRequestSpecOssConfig SpecOssConfig { get; set; }
        public class ImportHttpApiRequestSpecOssConfig : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-1</para>
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
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The update policy when the API to be imported has the same version and name as an existing one. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SpectOnly: All configurations in the file take effect.</description></item>
        /// <item><description>SpecFirst: The file takes precedence. New APIs are created and existing ones are updated. APIs not included in the file remain unchanged.</description></item>
        /// <item><description>ExistFirst (default): The existing APIs take precedence. New APIs are created but existing ones remain unchanged.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The API to be updated. If this parameter is specified, this import updates only the specified API. New APIs are not created and unspecified existing APIs are not updated. Only REST APIs can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("targetHttpApiId")]
        [Validation(Required=false)]
        public string TargetHttpApiId { get; set; }

        /// <summary>
        /// <para>Version configuration.</para>
        /// </summary>
        [NameInMap("versionConfig")]
        [Validation(Required=false)]
        public HttpApiVersionConfig VersionConfig { get; set; }

    }

}
