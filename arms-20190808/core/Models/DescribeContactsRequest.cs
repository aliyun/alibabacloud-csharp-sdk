// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactsRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact that you want to query. Separate multiple contact IDs with spaces.
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// The name of the alert contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The email address of the alert contact.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The mobile number of the alert contact.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of alert contacts to return on each page.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Specifies whether to return redundant information.
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public string Verbose { get; set; }

    }

}
