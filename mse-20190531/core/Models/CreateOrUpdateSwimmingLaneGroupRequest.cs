// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneGroupRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The IDs of applications. Separate application IDs with commas (,).
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        [NameInMap("CanaryModel")]
        [Validation(Required=false)]
        public int? CanaryModel { get; set; }

        /// <summary>
        /// Specifies whether to enable database canary release.
        /// </summary>
        [NameInMap("DbGrayEnable")]
        [Validation(Required=false)]
        public bool? DbGrayEnable { get; set; }

        /// <summary>
        /// The ingress application.
        /// </summary>
        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        /// <summary>
        /// The ID of the lane group. A value of -1 is used to create a lane group. A value greater than 0 is used to modify the specified lane group.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The side for message filtering when the canary release for messaging feature is enabled.
        /// </summary>
        [NameInMap("MessageQueueFilterSide")]
        [Validation(Required=false)]
        public string MessageQueueFilterSide { get; set; }

        /// <summary>
        /// Specifies whether to enable canary release for messaging.
        /// </summary>
        [NameInMap("MessageQueueGrayEnable")]
        [Validation(Required=false)]
        public bool? MessageQueueGrayEnable { get; set; }

        /// <summary>
        /// The name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the Microservices Engine (MSE) namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Specifies whether to record request details.
        /// </summary>
        [NameInMap("RecordCanaryDetail")]
        [Validation(Required=false)]
        public bool? RecordCanaryDetail { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RouteIds")]
        [Validation(Required=false)]
        public List<long?> RouteIds { get; set; }

        /// <summary>
        /// The status of the lane group. The value 0 specifies that the lane group is disabled. The value 1 specifies that the lane group is enabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SwimVersion")]
        [Validation(Required=false)]
        public int? SwimVersion { get; set; }

    }

}
