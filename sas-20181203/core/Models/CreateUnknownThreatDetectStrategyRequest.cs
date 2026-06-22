// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUnknownThreatDetectStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The asset selection type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_THREAT_DETECT_CONFIG_****</para>
        /// </summary>
        [NameInMap("AssetSelectionType")]
        [Validation(Required=false)]
        public string AssetSelectionType { get; set; }

        /// <summary>
        /// <para>The duration of the initial learning period, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterInit")]
        [Validation(Required=false)]
        public int? DurationDaysAfterInit { get; set; }

        /// <summary>
        /// <para>The number of consecutive days without detecting new processes before the learning process stops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterStop")]
        [Validation(Required=false)]
        public int? DurationDaysAfterStop { get; set; }

        /// <summary>
        /// <para>The strategy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategy****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The whitelist mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>hash</b>: The process hash.</para>
        /// </description></item>
        /// <item><description><para><b>path</b>: The process path.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

    }

}
