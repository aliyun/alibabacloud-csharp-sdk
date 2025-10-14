// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetUserConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserConfigResponseBodyUser User { get; set; }
        public class GetUserConfigResponseBodyUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("CtdrVersion")]
            [Validation(Required=false)]
            public string CtdrVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("DataStorageVersion")]
            [Validation(Required=false)]
            public string DataStorageVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("UpgradeCtdrVersion")]
            [Validation(Required=false)]
            public string UpgradeCtdrVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

        }

    }

}
