// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateSasTrialRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public CreateSasTrialRequestSdkRequest SdkRequest { get; set; }
        public class CreateSasTrialRequestSdkRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FromEcs")]
            [Validation(Required=false)]
            public bool? FromEcs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            [NameInMap("RequestForm")]
            [Validation(Required=false)]
            public CreateSasTrialRequestSdkRequestRequestForm RequestForm { get; set; }
            public class CreateSasTrialRequestSdkRequestRequestForm : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>for poc</para>
                /// </summary>
                [NameInMap("TryReason")]
                [Validation(Required=false)]
                public string TryReason { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TryType")]
            [Validation(Required=false)]
            public int? TryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TryVersion")]
            [Validation(Required=false)]
            public int? TryVersion { get; set; }

        }

    }

}
