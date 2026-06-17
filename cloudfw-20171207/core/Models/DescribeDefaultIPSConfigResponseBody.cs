// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDefaultIPSConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the basic policies feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled</para>
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
        /// <para>The status of the threat intelligence feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled</para>
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
        /// <para>The maximum daily traffic that can be scanned for sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSdl")]
        [Validation(Required=false)]
        public long? MaxSdl { get; set; }

        /// <summary>
        /// <para>The status of the virtual patching feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133173B9-8010-5DF5-8B93-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The strictness level of the intrusion prevention system (IPS) rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Loose</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Medium</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Strict</para>
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
        /// <para>The mode of the IPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Block Mode</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Monitor Mode</para>
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
