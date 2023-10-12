// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The remarks of the member. The remarks must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("MemberDesc")]
        [Validation(Required=false)]
        public string MemberDesc { get; set; }

        /// <summary>
        /// The name of the member.
        /// </summary>
        [NameInMap("MemberDisplayName")]
        [Validation(Required=false)]
        public string MemberDisplayName { get; set; }

        /// <summary>
        /// The UID of the member.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
