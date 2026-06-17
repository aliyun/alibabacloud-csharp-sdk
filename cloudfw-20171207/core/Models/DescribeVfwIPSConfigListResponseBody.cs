// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVfwIPSConfigListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of configurations.</para>
        /// </summary>
        [NameInMap("VfwIpsSwitchConfigList")]
        [Validation(Required=false)]
        public List<DescribeVfwIPSConfigListResponseBodyVfwIpsSwitchConfigList> VfwIpsSwitchConfigList { get; set; }
        public class DescribeVfwIPSConfigListResponseBodyVfwIpsSwitchConfigList : TeaModel {
            /// <summary>
            /// <para>The status of the basic policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BasicRules")]
            [Validation(Required=false)]
            public int? BasicRules { get; set; }

            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>134646920647****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The status of the virtual patching policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PatchRules")]
            [Validation(Required=false)]
            public int? PatchRules { get; set; }

            /// <summary>
            /// <para>The policy for the block mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleClass")]
            [Validation(Required=false)]
            public int? RuleClass { get; set; }

            /// <summary>
            /// <para>The protection mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public int? RunMode { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-h678sl4wv3yd5v****</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <para>The list of instance IDs of the VPC firewalls.</para>
            /// </summary>
            [NameInMap("VpcFirewallIdList")]
            [Validation(Required=false)]
            public List<string> VpcFirewallIdList { get; set; }

            /// <summary>
            /// <para>The instance name of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-test</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
