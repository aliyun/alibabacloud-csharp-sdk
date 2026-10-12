// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchImportHttpApisRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to overwrite existing APIs. If set to true, gatewayId is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("allowUpdate")]
        [Validation(Required=false)]
        public bool? AllowUpdate { get; set; }

        /// <summary>
        /// <para>The API type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("apiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>Enables the dry run feature, which validates the definition without performing the actual import.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The gateway instance ID. For REST APIs, this parameter is required when withGatewayExtension is set to true or allowUpdate is set to true. For batch import of HTTP APIs, this parameter is always required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The standard Base64 encoding of the raw bytes of the OAS ZIP package. The decoded size cannot exceed 10 MiB. This parameter cannot be specified together with specFileUrl or specOssConfig. Dry run is supported and returns validation results, but the dry run task result does not return a replayable importRequest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3BlbmFwaTogMy4wLjAKaW5mbzoKICAgIHRpdGxlOiBkZW1vCiAgICBkZXNjcmlwdGlvbjogdGhpc2lzZGVtbwogICAgdmVyc2lvbjogIiIKcGF0aHM6CiAgICAvdXNlci97dXNlcklkfToKICAgICAgICBnZXQ6CiAgICAgICAgICAgIHN1bW1hcnk6IOiOt+WPlueUqOaIt+S/oeaBrwogICAgICAgICAgICBkZXNjcmlwdGlvbjog6I635Y+W55So5oi35L+h5oGvCiAgICAgICAgICAgIG9wZXJhdGlvbklkOiBHZXRVc2VySW5mbwogICAgICAgICAgICByZXNwb25zZXM6CiAgICAgICAgICAgICAgICAiMjAwIjoKICAgICAgICAgICAgICAgICAgICBkZXNjcmlwdGlvbjog5oiQ5YqfCiAgICAgICAgICAgICAgICAgICAgY29udGVudDoKICAgICAgICAgICAgICAgICAgICAgICAgYXBwbGljYXRpb24vanNvbjtjaGFyc2V0PXV0Zi04OgogICAgICAgICAgICAgICAgICAgICAgICAgICAgc2NoZW1hOiBudWxsCnNlcnZlcnM6CiAgICAtIHVybDogaHR0cDovL2FwaS5leGFtcGxlLmNvbS92MQo=</para>
        /// </summary>
        [NameInMap("specContentBase64")]
        [Validation(Required=false)]
        public string SpecContentBase64 { get; set; }

        /// <summary>
        /// <para>The download URL of the OAS ZIP file. The URL must support unauthenticated downloads. OSS URLs and whitelisted backend domain names are supported. At least one of specFileUrl and specOssConfig must be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com/my-bucket/imports/batch.zip">https://oss-cn-hangzhou.aliyuncs.com/my-bucket/imports/batch.zip</a></para>
        /// </summary>
        [NameInMap("specFileUrl")]
        [Validation(Required=false)]
        public string SpecFileUrl { get; set; }

        /// <summary>
        /// <para>The OSS configuration for the OAS file in ZIP format. At least one of specFileUrl and specOssConfig must be specified.</para>
        /// </summary>
        [NameInMap("specOssConfig")]
        [Validation(Required=false)]
        public BatchImportHttpApisRequestSpecOssConfig SpecOssConfig { get; set; }
        public class BatchImportHttpApisRequestSpecOssConfig : TeaModel {
            /// <summary>
            /// <para>The OSS bucket name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-bucket</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>OSS Object Key。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imports/batch.zip</para>
            /// </summary>
            [NameInMap("objectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The region ID of the OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The conflict merge strategy during import. Default value: ExistFirst.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to import with gateway extension configurations. This parameter must be set to true for batch import of HTTP APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withGatewayExtension")]
        [Validation(Required=false)]
        public bool? WithGatewayExtension { get; set; }

    }

}
