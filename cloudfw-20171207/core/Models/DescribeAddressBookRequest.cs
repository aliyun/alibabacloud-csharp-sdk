// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookRequest : TeaModel {
        /// <summary>
        /// The port that is included in the address book. This parameter takes effect only when the **GroupType** parameter is set to **port**.
        /// </summary>
        [NameInMap("ContainPort")]
        [Validation(Required=false)]
        public string ContainPort { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The type of the address book. Valid values:
        /// 
        /// *   **ip**: IP address book
        /// *   **domain**: domain address book
        /// *   **port**: port address book
        /// *   **tag**: Elastic Compute Service (ECS) tag-based address book
        /// *   **allCloud**: cloud service address book
        /// *   **threat**: threat intelligence address book
        /// *   **ipv6**: IPv6 address book
        /// >  If you do not specify a type, the domain address books and ECS tag-based address books are queried.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The language of the content within the request. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Default value: 10. Maximum value: 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The query condition that is used to search for the address book.
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
