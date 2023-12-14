// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateMaliciousFileWhitelistConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the whitelist rule. If you do not specify this parameter, a whitelist rule is created.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// The name of the alert.
        /// 
        /// *   Set the value to ALL, which indicates all alert types.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The field that you want to use in the whitelist rule.
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The value of the field that you want to use in the whitelist rule.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// The logical operator that you want to use in the whitelist rule.
        /// 
        /// *   Set the value to strEqual, which indicates the equality operator (=).
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// The feature to which this operation belongs.
        /// 
        /// *   Set the value to agentless, which indicates the agentless detection feature.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of the assets on which you want the whitelist rule to take effect. Valid values:
        /// 
        /// *   ALL: all assets
        /// *   SELECTION_KEY: selected assets
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The assets on which you want the whitelist rule to take effect. Valid values:
        /// 
        /// *   ALL: all assets
        /// *   Others: selected assets
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

    }

}
