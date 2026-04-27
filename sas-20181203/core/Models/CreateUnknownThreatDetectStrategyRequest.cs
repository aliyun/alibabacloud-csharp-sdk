// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUnknownThreatDetectStrategyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UNKNOWN_THREAT_DETECT_CONFIG_****</para>
        /// </summary>
        [NameInMap("AssetSelectionType")]
        [Validation(Required=false)]
        public string AssetSelectionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterInit")]
        [Validation(Required=false)]
        public int? DurationDaysAfterInit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterStop")]
        [Validation(Required=false)]
        public int? DurationDaysAfterStop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>strategy****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

    }

}
