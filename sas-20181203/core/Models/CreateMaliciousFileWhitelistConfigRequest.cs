// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// <para>Alert name:</para>
        /// <list type="bullet">
        /// <item><description>ALL: All alerts</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>Field used for whitelist in sensitive file alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileMd5</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>Expected value of the field to be whitelisted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2cf9747ee49d8d9b105cf16e078cc16</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>Rule judgment operator:</para>
        /// <list type="bullet">
        /// <item><description>strEqual: String equals</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>strEqual</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>Remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Business source:</para>
        /// <list type="bullet">
        /// <item><description>agentless: Agentless detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Effective target type:</para>
        /// <list type="bullet">
        /// <item><description>ALL: All assets</description></item>
        /// <item><description>SELECTION_KEY: Assets selected via the asset selection component</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>Target effective scope:</para>
        /// <list type="bullet">
        /// <item><description>ALL: All assets</description></item>
        /// <item><description>Other: Key of the asset range selected by the asset selection component</description></item>
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
