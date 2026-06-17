// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeIpsPrivateAssocResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of details about private IP tracing for the intrusion prevention system (IPS).</para>
        /// </summary>
        [NameInMap("IpsPrivateAssoc")]
        [Validation(Required=false)]
        public List<DescribeIpsPrivateAssocResponseBodyIpsPrivateAssoc> IpsPrivateAssoc { get; set; }
        public class DescribeIpsPrivateAssocResponseBodyIpsPrivateAssoc : TeaModel {
            /// <summary>
            /// <para>The status of private IP tracing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>close</para>
            /// </summary>
            [NameInMap("AssocInfoStatus")]
            [Validation(Required=false)]
            public string AssocInfoStatus { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliuid:1096080848305847 assumeOssRole not exist,serviceName:aliyunesarealtimelogpushossrole</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the resource owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1507956024994407</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>A list of protected IP addresses.</para>
            /// </summary>
            [NameInMap("ProtectedIpList")]
            [Validation(Required=false)]
            public List<string> ProtectedIpList { get; set; }

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
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cba48ec510bb640559c6f5161cde58014</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-0000000061279FB000001BBB31F9D673</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The status of the association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>closed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of unprotected IP addresses.</para>
            /// </summary>
            [NameInMap("UnprotectedIpList")]
            [Validation(Required=false)]
            public List<string> UnprotectedIpList { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz92dxepli2pgnut796tf</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf62vdtifj7kffpxrydqd</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2841452-CB8D-4F7D-B247-38E1CF7334F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of assets that have private IP tracing for the IPS enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalOpenCount")]
        [Validation(Required=false)]
        public long? TotalOpenCount { get; set; }

    }

}
