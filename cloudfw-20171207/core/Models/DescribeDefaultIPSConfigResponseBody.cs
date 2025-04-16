// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDefaultIPSConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether basic protection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
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
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public int? CtiRules { get; set; }

        /// <summary>
        /// <para>The maximum amount of traffic that can be processed by the sensitive data leak detection feature each day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSdl")]
        [Validation(Required=false)]
        public long? MaxSdl { get; set; }

        /// <summary>
        /// <para>Indicates whether virtual patching is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
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
        /// <para>The level of the rule group for the IPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: loose</description></item>
        /// <item><description><b>2</b>: medium</description></item>
        /// <item><description><b>3</b>: strict</description></item>
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
        /// <item><description><b>1</b>: block mode</description></item>
        /// <item><description><b>0</b>: monitor mode</description></item>
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
