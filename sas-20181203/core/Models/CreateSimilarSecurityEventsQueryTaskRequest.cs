// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSimilarSecurityEventsQueryTaskRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the alert event.
        /// 
        /// >  You must specify at least one of the SecurityEventId and SimilarEventScenarioCode parameters.
        /// </summary>
        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public long? SecurityEventId { get; set; }

        /// <summary>
        /// The codes of alert events that are triggered by the same rule or of the same alert type.
        /// 
        /// >  You must specify at least one of the SecurityEventId and SimilarEventScenarioCode parameters.
        /// </summary>
        [NameInMap("SimilarEventScenarioCode")]
        [Validation(Required=false)]
        public string SimilarEventScenarioCode { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
