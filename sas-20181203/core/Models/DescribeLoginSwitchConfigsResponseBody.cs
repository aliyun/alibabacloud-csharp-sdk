// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginSwitchConfigsResponseBody : TeaModel {
        /// <summary>
        /// The configuration item returned.
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeLoginSwitchConfigsResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeLoginSwitchConfigsResponseBodyConfigList : TeaModel {
            /// <summary>
            /// The type of the alert that you enabled or disabled. Valid values:
            /// 
            /// *   **login_common_ip**: alerts for unapproved logon IP addresses
            /// *   **login_common_time**: alerts for unapproved logon time ranges
            /// *   **login_common_account**: alerts for unapproved logon accounts
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// The status of the Log Service feature. Valid values:
            /// 
            /// *   **0**: The feature is disabled.
            /// *   **1**: The feature is enabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The number of returned configuration items.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
