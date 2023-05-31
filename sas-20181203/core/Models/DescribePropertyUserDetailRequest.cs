// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the fuzzy search by account name is supported. If you want to use fuzzy search, set the parameter to **1**. If you set the parameter to a different value or leave the parameter empty, fuzzy search is not supported.
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// Specifies whether the account has root permissions. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("IsRoot")]
        [Validation(Required=false)]
        public string IsRoot { get; set; }

        /// <summary>
        /// The timestamp of the last logoff from the account. Unit: milliseconds.
        /// </summary>
        [NameInMap("LastLoginTimeEnd")]
        [Validation(Required=false)]
        public long? LastLoginTimeEnd { get; set; }

        /// <summary>
        /// The timestamp of the last logon to the account. Unit: milliseconds.
        /// </summary>
        [NameInMap("LastLoginTimeStart")]
        [Validation(Required=false)]
        public long? LastLoginTimeStart { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The name of the account to which the server belongs.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
