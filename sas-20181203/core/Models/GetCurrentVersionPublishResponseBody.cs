// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCurrentVersionPublishResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCurrentVersionPublishResponseBodyData Data { get; set; }
        public class GetCurrentVersionPublishResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoUpgrade")]
            [Validation(Required=false)]
            public int? AutoUpgrade { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BigCustomer")]
            [Validation(Required=false)]
            public bool? BigCustomer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.8</para>
            /// </summary>
            [NameInMap("CurVersion")]
            [Validation(Required=false)]
            public string CurVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1732506308000</para>
            /// </summary>
            [NameInMap("ForceUpgradeTime")]
            [Validation(Required=false)]
            public long? ForceUpgradeTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GraySwitchStatus")]
            [Validation(Required=false)]
            public int? GraySwitchStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1662639150000</para>
            /// </summary>
            [NameInMap("LatestVersionCreate")]
            [Validation(Required=false)]
            public long? LatestVersionCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LatestVersionDesc")]
            [Validation(Required=false)]
            public string LatestVersionDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public int? PublishStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("UpgradeVersion")]
            [Validation(Required=false)]
            public string UpgradeVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8E67FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
