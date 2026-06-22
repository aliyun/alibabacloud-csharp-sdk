// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about images.</para>
        /// </summary>
        [NameInMap("ImageInfos")]
        [Validation(Required=false)]
        public List<DescribeImageInfoListResponseBodyImageInfos> ImageInfos { get; set; }
        public class DescribeImageInfoListResponseBodyImageInfos : TeaModel {
            /// <summary>
            /// <para>The number of alerts detected in the current pod, application, namespace, or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset has security alerts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: Security alerts exist.</description></item>
            /// <item><description><b>NO</b>: No security alerts exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The digest value of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a3521b04dfdd1361a24be6263f2983cf12ba910989f4d9f7324da7e1e89f****</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The list of endpoints for the image service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-x7</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636962328000</para>
            /// </summary>
            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public long? ImageCreate { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb0175afea16138815a8900adeeb0315d88a83a2376eeffa14db1d693a15****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>157408623</para>
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public long? ImageSize { get; set; }

            /// <summary>
            /// <para>The time when the image was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636974116000</para>
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public long? ImageUpdate { get; set; }

            /// <summary>
            /// <para>The ID of the image instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz95abw6pa7y79ve****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the image instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The registry type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>harbor</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-5qk9v2rdt0s****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opa-test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>libssh2</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The repository type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PUBLIC</c>: public</para>
            /// </description></item>
            /// <item><description><para><c>PRIVATE</c>: private</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>Indicates whether the image has security risks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: The image has risks.</description></item>
            /// <item><description><b>NO</b>: The image does not have risks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The business purpose tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI</para>
            /// </summary>
            [NameInMap("SourceBizTag")]
            [Validation(Required=false)]
            public string SourceBizTag { get; set; }

            /// <summary>
            /// <para>The image status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The tag immutability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TagImmutable")]
            [Validation(Required=false)]
            public int? TagImmutable { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ff9ca084-7faa-4ab2-8728-69024755****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The total number of vulnerabilities in your assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has vulnerabilities. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: Vulnerabilities exist.</description></item>
            /// <item><description><b>NO</b>: No vulnerabilities exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is a unique identifier generated by Alibaba Cloud for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC3B0DAE-CC0E-59E9-9383-6F060F22****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
