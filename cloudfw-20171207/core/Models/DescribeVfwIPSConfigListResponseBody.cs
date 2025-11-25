// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVfwIPSConfigListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VfwIpsSwitchConfigList")]
        [Validation(Required=false)]
        public List<DescribeVfwIPSConfigListResponseBodyVfwIpsSwitchConfigList> VfwIpsSwitchConfigList { get; set; }
        public class DescribeVfwIPSConfigListResponseBodyVfwIpsSwitchConfigList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BasicRules")]
            [Validation(Required=false)]
            public int? BasicRules { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>134646920647****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PatchRules")]
            [Validation(Required=false)]
            public int? PatchRules { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleClass")]
            [Validation(Required=false)]
            public int? RuleClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public int? RunMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cen-h678sl4wv3yd5v****</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            [NameInMap("VpcFirewallIdList")]
            [Validation(Required=false)]
            public List<string> VpcFirewallIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-test</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
