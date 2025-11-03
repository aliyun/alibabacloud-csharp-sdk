// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to ALL, which indicates all alert types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The field that you want to use in the whitelist rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileMd5</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The value of the field that you want to use in the whitelist rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2cf9747ee49d8d9b105cf16e078cc16</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The logical operator that you want to use in the whitelist rule.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to strEqual, which indicates the equality operator (=).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>strEqual</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The feature to which this operation belongs.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to agentless, which indicates the agentless detection feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the assets on which you want the whitelist rule to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: all assets</description></item>
        /// <item><description>SELECTION_KEY: selected assets</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The assets on which you want the whitelist rule to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: all assets</description></item>
        /// <item><description>Others: selected assets</description></item>
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
