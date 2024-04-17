// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class UpdateWhiteRuleListRequest : TeaModel {
        /// <summary>
        /// The alert whitelist rule. The value is a JSON object.
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// The UUID of the event.
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// The unique ID of the whitelist rule.
        /// </summary>
        [NameInMap("WhiteRuleId")]
        [Validation(Required=false)]
        public long? WhiteRuleId { get; set; }

    }

}
