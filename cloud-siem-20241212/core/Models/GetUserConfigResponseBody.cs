// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetUserConfigResponseBody : TeaModel {
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
        /// <para>The user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserConfigResponseBodyUser User { get; set; }
        public class GetUserConfigResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The current Cloud Threat Detection and Response (CTDR) version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("CtdrVersion")]
            [Validation(Required=false)]
            public string CtdrVersion { get; set; }

            /// <summary>
            /// <para>The upgrade status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: Pending upgrade.</description></item>
            /// <item><description>upgrading: Upgrading.</description></item>
            /// <item><description>success: Upgrade succeeded.</description></item>
            /// <item><description>failed: Upgrade failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("DataStorageVersion")]
            [Validation(Required=false)]
            public string DataStorageVersion { get; set; }

            /// <summary>
            /// <para>The log management version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("UpgradeCtdrVersion")]
            [Validation(Required=false)]
            public string UpgradeCtdrVersion { get; set; }

            /// <summary>
            /// <para>The CTDR version to upgrade to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

        }

    }

}
