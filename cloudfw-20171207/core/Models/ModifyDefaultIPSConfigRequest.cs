// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyDefaultIPSConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable basic protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public string BasicRules { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable threat intelligence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public string CtiRules { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default)</description></item>
        /// <item><description><b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("MaxSdl")]
        [Validation(Required=false)]
        public long? MaxSdl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable virtual patching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public string PatchRules { get; set; }

        /// <summary>
        /// <para>The level of the rule group for the IPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: loose</description></item>
        /// <item><description><b>2</b>: medium</description></item>
        /// <item><description><b>3</b>: strict</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// <para>The mode of the IPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: block mode</description></item>
        /// <item><description><b>0</b>: monitor mode</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

    }

}
