// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact group. You can query multiple alert contact groups at a time. Separate multiple group IDs with commas (,).
        /// </summary>
        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        /// <summary>
        /// The name of the alert contact group.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// The ID of the alert contact. You can call the SearchAlertContact operation to query the contact IDs. For more information, see [SearchAlertContact](~~130703~~).
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// The name of the alert contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Specifies whether to return all alert contacts in the queried alert contact group. By default, not all alert contacts are returned.
        /// </summary>
        [NameInMap("IsDetail")]
        [Validation(Required=false)]
        public bool? IsDetail { get; set; }

        /// <summary>
        /// The ID of the region. Default value: `cn-hangzhou`.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
