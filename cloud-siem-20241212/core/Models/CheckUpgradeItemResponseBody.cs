// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CheckUpgradeItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upgrade item.</para>
        /// </summary>
        [NameInMap("UpgradeItem")]
        [Validation(Required=false)]
        public CheckUpgradeItemResponseBodyUpgradeItem UpgradeItem { get; set; }
        public class CheckUpgradeItemResponseBodyUpgradeItem : TeaModel {
            /// <summary>
            /// <para>The name of the module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public string CheckResult { get; set; }

            /// <summary>
            /// <para>The check status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            /// <summary>
            /// <para>The ID of the upgrade item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>incident_upgrade</para>
            /// </summary>
            [NameInMap("UpgradeItemId")]
            [Validation(Required=false)]
            public string UpgradeItemId { get; set; }

        }

    }

}
