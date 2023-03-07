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

        /// <summary>
        /// Specifies whether to enable database canary release.
        /// </summary>
        [NameInMap("DbGrayEnable")]
        [Validation(Required=false)]
        public bool? DbGrayEnable { get; set; }

        /// <summary>
        /// Specifies whether to enable a lane group.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The ingress application.
        /// </summary>
        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// The update time.
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// The ID of the primary key. The primary key is auto-increment.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The license key in use.
        /// </summary>
        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

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
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RecordCanaryDetail")]
        [Validation(Required=false)]
        public bool? RecordCanaryDetail { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The service source. Valid value: edasmsc.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The status of the lane group. The value 0 specifies that the lane group is disabled. The value 1 specifies that the lane group is enabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The Alibaba Cloud account. The value is a number, such as 136246\*\*\*\*\*\*809. You can leave this parameter empty.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
