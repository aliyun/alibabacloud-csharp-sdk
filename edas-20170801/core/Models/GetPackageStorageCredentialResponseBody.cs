// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetPackageStorageCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The STS credential.</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public GetPackageStorageCredentialResponseBodyCredential Credential { get; set; }
        public class GetPackageStorageCredentialResponseBodyCredential : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of your account.</para>
            /// 
            /// <b>Example:</b>
            /// <yourAccessKeyId>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of your account.</para>
            /// 
            /// <b>Example:</b>
            /// <yourAccessKeySecret>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas-bj</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The time when the STS credential expires. Example: 2019-11-10T07:20:19Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-11-10T07:20:19Z</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The object key prefix in Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>release-pkg/117274586608****</para>
            /// </summary>
            [NameInMap("KeyPrefix")]
            [Validation(Required=false)]
            public string KeyPrefix { get; set; }

            /// <summary>
            /// <para>The private endpoint of OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-beijing-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssInternalEndpoint")]
            [Validation(Required=false)]
            public string OssInternalEndpoint { get; set; }

            /// <summary>
            /// <para>The public endpoint of OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-beijing.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssPublicEndpoint")]
            [Validation(Required=false)]
            public string OssPublicEndpoint { get; set; }

            /// <summary>
            /// <para>The VPC endpoint of OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-beijing-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssVpcEndpoint")]
            [Validation(Required=false)]
            public string OssVpcEndpoint { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The security token issued by STS.</para>
            /// 
            /// <b>Example:</b>
            /// <yourSecurityToken>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
