// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The remarks of the member in Cloud Firewall. The length is 1 ~ 256 characters.
        /// </summary>
        [NameInMap("MemberDesc")]
        [Validation(Required=false)]
        public string MemberDesc { get; set; }

        /// <summary>
        /// The name of the member in Cloud Firewall.
        /// </summary>
        [NameInMap("MemberDisplayName")]
        [Validation(Required=false)]
        public string MemberDisplayName { get; set; }

        /// <summary>
        /// The unique identifier (UID) of the member in Cloud Firewall.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
