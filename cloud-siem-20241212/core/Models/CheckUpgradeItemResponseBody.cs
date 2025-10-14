// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CheckUpgradeItemResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UpgradeItem")]
        [Validation(Required=false)]
        public CheckUpgradeItemResponseBodyUpgradeItem UpgradeItem { get; set; }
        public class CheckUpgradeItemResponseBodyUpgradeItem : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public string CheckResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>incident_upgrade</para>
            /// </summary>
            [NameInMap("UpgradeItemId")]
            [Validation(Required=false)]
            public string UpgradeItemId { get; set; }

        }

    }

}
