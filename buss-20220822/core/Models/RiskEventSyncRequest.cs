// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class RiskEventSyncRequest : TeaModel {
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DiscoveryTime")]
        [Validation(Required=false)]
        public long? DiscoveryTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("EventNumber")]
        [Validation(Required=false)]
        public string EventNumber { get; set; }

        [NameInMap("RelevanceBu")]
        [Validation(Required=false)]
        public string RelevanceBu { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RiskDetail")]
        [Validation(Required=false)]
        public string RiskDetail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RiskEffectType")]
        [Validation(Required=false)]
        public string RiskEffectType { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Submitter")]
        [Validation(Required=false)]
        public string Submitter { get; set; }

    }

}
