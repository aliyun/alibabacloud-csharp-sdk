// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchUpdateMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of whitelist rules for sensitive file alerts in agentless detection.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<BatchUpdateMaliciousFileWhitelistConfigRequestConfigList> ConfigList { get; set; }
        public class BatchUpdateMaliciousFileWhitelistConfigRequestConfigList : TeaModel {
            /// <summary>
            /// <para>The ID of the whitelist rule for sensitive file alerts in agentless detection. This parameter is optional. If you do not specify this parameter, a new rule is created. You can call the <a href="~~ListMaliciousFileWhitelistConfigs~~">ListMaliciousFileWhitelistConfigs</a> operation to obtain the ID of the whitelist rule for sensitive files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The alerting name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL</b>: all Alarm Metrics.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The field used to determine the whitelist for sensitive file alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileMd5</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The expected field value to be whitelisted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2cf9747ee49d8d9b105cf16e078cc16</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The operator used to evaluate the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>strEqual: equal to.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>strEqual</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The business source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>agentless: agentless detection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>agentless</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The type of the target to which the rule applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: all assets.</description></item>
            /// <item><description>SELECTION_KEY: assets selected by using the asset selection component.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The scope of the target to which the rule applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: all assets.</description></item>
            /// <item><description>Other values: the key of the asset scope selected by using the asset selection component.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

        }

    }

}
