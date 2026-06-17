// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDomainListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallDomainListResponseBodyDataList> DataList { get; set; }
        public class DescribeVpcFirewallDomainListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The list of application layer protocols.</para>
            /// </summary>
            [NameInMap("ApplicationNameList")]
            [Validation(Required=false)]
            public List<string> ApplicationNameList { get; set; }

            /// <summary>
            /// <para>The business to which the domain name belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Google</para>
            /// </summary>
            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.a.com">www.a.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The organization to which the domain name belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Google</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The volume of request traffic to the domain name. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3214</para>
            /// </summary>
            [NameInMap("RequestBytes")]
            [Validation(Required=false)]
            public long? RequestBytes { get; set; }

            /// <summary>
            /// <para>The volume of response traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4582</para>
            /// </summary>
            [NameInMap("ResponseBytes")]
            [Validation(Required=false)]
            public long? ResponseBytes { get; set; }

            /// <summary>
            /// <para>The number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The number of source IP addresses that are used to access the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SrcIpCount")]
            [Validation(Required=false)]
            public long? SrcIpCount { get; set; }

            /// <summary>
            /// <para>The number of source VPCs that are used to access the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SrcVpcCount")]
            [Validation(Required=false)]
            public long? SrcVpcCount { get; set; }

            /// <summary>
            /// <para>The total traffic volume. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8111126106</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133173B9-8010-5DF5-8B93-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
