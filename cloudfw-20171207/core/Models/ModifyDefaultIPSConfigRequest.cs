// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyDefaultIPSConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Basic Policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: shutdown.</para>
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
        /// <para>Specifies whether to enable threat intelligence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disable.</para>
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
        /// <para>The language type of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The daily traffic limit for sensitive data detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxSdl")]
        [Validation(Required=false)]
        public long? MaxSdl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable virtual patches. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public int? PatchRules { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public int? RuleClass { get; set; }

        /// <summary>
        /// <para>The IPS defense mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Block Mode.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: monitor mode.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public int? RunMode { get; set; }

    }

}
