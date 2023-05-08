// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The details of asset fingerprints for the account.
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// The details of the user groups to which the account belongs.
        /// </summary>
        [NameInMap("IsRoot")]
        [Validation(Required=false)]
        public string IsRoot { get; set; }

        /// <summary>
        /// The details of the user groups to which the account belongs.
        /// </summary>
        [NameInMap("LastLoginTimeEnd")]
        [Validation(Required=false)]
        public long? LastLoginTimeEnd { get; set; }

        /// <summary>
        /// The date on which the account expires.
        /// </summary>
        [NameInMap("LastLoginTimeStart")]
        [Validation(Required=false)]
        public long? LastLoginTimeStart { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Indicates whether the password expires. Valid values:
        /// 
        /// *   **0**: yes
        /// *   **1**: no
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
