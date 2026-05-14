// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ApprovePolarClawDevicePairResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-********************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Device")]
        [Validation(Required=false)]
        public ApprovePolarClawDevicePairResponseBodyDevice Device { get; set; }
        public class ApprovePolarClawDevicePairResponseBodyDevice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1778662316663</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>server</para>
            /// </summary>
            [NameInMap("DeviceFamily")]
            [Validation(Required=false)]
            public string DeviceFamily { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>device-l7rdl36iz6op66zf</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<string> Scopes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>req-abc-123</para>
        /// </summary>
        [NameInMap("PairRequestId")]
        [Validation(Required=false)]
        public string PairRequestId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>25C70FF3-D49B-594D-BECE-0DE2BA1D8BBB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
