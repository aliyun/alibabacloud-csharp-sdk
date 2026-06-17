// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDefaultIPSConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether basic policies are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: On.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Off.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public int? BasicRules { get; set; }

        /// <summary>
        /// <para>Indicates whether virtual patching is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: On.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Off.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public int? EnableAllPatch { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-****-00090125adf1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IPS rule group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Loose rule group.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Medium rule group.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Strict rule group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public int? RuleClass { get; set; }

        /// <summary>
        /// <para>The mode of the intrusion prevention system (IPS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Block Mode.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Monitor Mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public int? RunMode { get; set; }

    }

}
