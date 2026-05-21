// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetLastUpgradeRecordResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLastUpgradeRecordResponseBodyData Data { get; set; }
        public class GetLastUpgradeRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>r3.2.11</para>
            /// </summary>
            [NameInMap("fromVersion")]
            [Validation(Required=false)]
            public string FromVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-24 17:29:57</para>
            /// </summary>
            [NameInMap("startReadonlyTime")]
            [Validation(Required=false)]
            public string StartReadonlyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-24 18:23:22</para>
            /// </summary>
            [NameInMap("stopReadonlyTime")]
            [Validation(Required=false)]
            public string StopReadonlyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>r4.0.2</para>
            /// </summary>
            [NameInMap("toVersion")]
            [Validation(Required=false)]
            public string ToVersion { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
