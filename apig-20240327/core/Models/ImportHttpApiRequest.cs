// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ImportHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The description of the imported API. If not provided, it will be extracted from the API definition. The length is limited to 255 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试专用API</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Pre-import check. If enabled, only the check will be performed without importing the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the imported API. If not provided, it will be extracted from the API definition file. If the API name and version configuration already exist, this import will update the existing API definition based on the <c>strategy</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3q4zjh7fkki</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Base64 encoded API definition, supporting OAS2.0 and OAS3.0 specifications, in YAML or JSON format. It has a higher priority than the <c>specFileUrl</c> parameter. If the file size exceeds 10MB, please use the <c>specFileUrl</c> parameter to transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3BlbmFwaTogMy4wLjAKaW5mbzoKICAgIHRpdGxlOiBkZW1vCiAgICBkZXNjcmlwdGlvbjogdGhpc2lzZGVtbwogICAgdmVyc2lvbjogIiIKcGF0aHM6CiAgICAvdXNlci97dXNlcklkfToKICAgICAgICBnZXQ6CiAgICAgICAgICAgIHN1bW1hcnk6IOiOt+WPlueUqOaIt+S/oeaBrwogICAgICAgICAgICBkZXNjcmlwdGlvbjog6I635Y+W55So5oi35L+h5oGvCiAgICAgICAgICAgIG9wZXJhdGlvbklkOiBHZXRVc2VySW5mbwogICAgICAgICAgICByZXNwb25zZXM6CiAgICAgICAgICAgICAgICAiMjAwIjoKICAgICAgICAgICAgICAgICAgICBkZXNjcmlwdGlvbjog5oiQ5YqfCiAgICAgICAgICAgICAgICAgICAgY29udGVudDoKICAgICAgICAgICAgICAgICAgICAgICAgYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PXV0Zi04OgogICAgICAgICAgICAgICAgICAgICAgICAgICAgc2NoZW1hOiBudWxsCnNlcnZlcnM6CiAgICAtIHVybDogaHR0cDovL2FwaS5leGFtcGxlLmNvbS92MQo=</para>
        /// </summary>
        [NameInMap("specContentBase64")]
        [Validation(Required=false)]
        public string SpecContentBase64 { get; set; }

        /// <summary>
        /// <para>Download URL for the API definition file, which must be accessible from the public network or via an internal OSS download address within the same region. The file URL must have download permissions. For non-publicly readable OSS file links, refer to the documentation at <a href="https://help.aliyun.com/zh/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">https://help.aliyun.com/zh/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects</a>, and provide a URL with download permissions. Currently, only API definition files stored on OSS are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/my-api/api.yaml">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/my-api/api.yaml</a></para>
        /// </summary>
        [NameInMap("specFileUrl")]
        [Validation(Required=false)]
        public string SpecFileUrl { get; set; }

        /// <summary>
        /// <para>The oss config info.</para>
        /// </summary>
        [NameInMap("specOssConfig")]
        [Validation(Required=false)]
        public ImportHttpApiRequestSpecOssConfig SpecOssConfig { get; set; }
        public class ImportHttpApiRequestSpecOssConfig : TeaModel {
            /// <summary>
            /// <para>The name of the Object Storage Service (OSS) bucket that stores the dictionary file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-1</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The file path.</para>
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
        /// <para>When the imported API name and version management match an existing API, you need to specify an update strategy.</para>
        /// <list type="bullet">
        /// <item><description>SpecOnly: Completely based on the imported file.</description></item>
        /// <item><description>SpecFirst: Prioritize the imported file, add new interfaces and update existing ones, while keeping interfaces not mentioned in the file unchanged.</description></item>
        /// <item><description>ExistFirst: Prioritize the existing API, only add new interfaces without updating existing ones.
        /// If not specified, the default strategy is ExistFirst.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>If this field is specified, this import will update the specified API instead of importing or searching for an existing API based on the API name and version management configuration. The target API must be of REST type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxxx</para>
        /// </summary>
        [NameInMap("targetHttpApiId")]
        [Validation(Required=false)]
        public string TargetHttpApiId { get; set; }

        /// <summary>
        /// <para>API versioning configuration. If versioning is enabled, and the version number and API name match an existing API, this import will be treated as an update. If versioning is not enabled, and the API name matches an existing API, this import will also be treated as an update.</para>
        /// </summary>
        [NameInMap("versionConfig")]
        [Validation(Required=false)]
        public HttpApiVersionConfig VersionConfig { get; set; }

    }

}
