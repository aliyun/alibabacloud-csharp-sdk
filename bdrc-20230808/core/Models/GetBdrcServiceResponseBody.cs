// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class GetBdrcServiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBdrcServiceResponseBodyData Data { get; set; }
        public class GetBdrcServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1726169608</para>
            /// </summary>
            [NameInMap("OpenTime")]
            [Validation(Required=false)]
            public long? OpenTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1726169608</para>
            /// </summary>
            [NameInMap("ProtectionScoreUpdatedTime")]
            [Validation(Required=false)]
            public long? ProtectionScoreUpdatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("ServiceInitializeStatus")]
            [Validation(Required=false)]
            public string ServiceInitializeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPENED</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5748C531-80B1-5C31-8421-63A1830B9E48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
