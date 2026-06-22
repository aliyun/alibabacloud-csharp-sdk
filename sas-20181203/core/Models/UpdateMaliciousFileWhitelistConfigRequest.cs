// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID. This parameter is optional. If you do not specify this parameter, a whitelist rule is created.</para>
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
        /// <item><description>ALL: all Alarm Metric.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The field to be whitelisted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileMd5</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The value of the field to be whitelisted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2cf9747ee49d8d9b105cf16e078cc16</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The operator used for rule matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>strEqual: string equals.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>strEqual</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

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
        /// <para>The type of the target scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: all assets</description></item>
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
        /// <para>The target scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: all assets</description></item>
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
