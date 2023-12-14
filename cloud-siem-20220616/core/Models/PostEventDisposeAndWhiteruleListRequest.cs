// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostEventDisposeAndWhiteruleListRequest : TeaModel {
        /// <summary>
        /// The configuration of event handling. The value is a JSON object.
        /// </summary>
        [NameInMap("EventDispose")]
        [Validation(Required=false)]
        public string EventDispose { get; set; }

        /// <summary>
        /// The UUID of the event.
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// The configuration of the alert recipient. The value is a JSON object.
        /// </summary>
        [NameInMap("ReceiverInfo")]
        [Validation(Required=false)]
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The remarks of the event.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The status of the event. Valid values:
        /// 
        /// *   0: unhandled
        /// *   1: handing
        /// *   5: handling failed
        /// *   10: handled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
