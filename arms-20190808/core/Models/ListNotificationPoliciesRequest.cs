// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListNotificationPoliciesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable simple mode.
        /// </summary>
        [NameInMap("DirectedMode")]
        [Validation(Required=false)]
        public bool? DirectedMode { get; set; }

        /// <summary>
        /// The ID of the notification policy.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Specifies whether to query the details about notification policies. Valid values:
        /// 
        /// *   `true`: Details about notification policies are queried.
        /// *   `false`: Details about notification policies are not queried.
        /// </summary>
        [NameInMap("IsDetail")]
        [Validation(Required=false)]
        public bool? IsDetail { get; set; }

        /// <summary>
        /// The name of the notification policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The ID of the region. Default value: **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
