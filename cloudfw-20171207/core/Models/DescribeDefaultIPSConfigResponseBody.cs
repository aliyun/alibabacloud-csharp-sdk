// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDefaultIPSConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether Basic Policies are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: shutdown.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public int? BasicRules { get; set; }

        /// <summary>
        /// <para>Indicates whether threat intelligence is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public int? CtiRules { get; set; }

        /// <summary>
        /// <para>The daily traffic limit for sensitive data detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSdl")]
        [Validation(Required=false)]
        public long? MaxSdl { get; set; }

        /// <summary>
        /// <para>Indicates whether virtual patches are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public int? PatchRules { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133173B9-8010-5DF5-8B93-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IPS rules group. Valid values:</para>
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
        /// <para>3</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public int? RuleClass { get; set; }

        /// <summary>
        /// <para>The IPS defense mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Block mode.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Monitor mode.</para>
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
