// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class TestConnectivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The result details of the connectivity test.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestConnectivityResponseBodyData Data { get; set; }
        public class TestConnectivityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The tracking identifier of the connectivity test. The system generates this value for the first call. For polling calls, this value is the same as the CheckId in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conn-a1b2c3d4e5f67890</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            /// <summary>
            /// <para>The end-to-end latency of the target service response, in milliseconds. This value may be 0 or not returned when VerifyStatus is checking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("LatencyMs")]
            [Validation(Required=false)]
            public long? LatencyMs { get; set; }

            /// <summary>
            /// <para>The detailed information of the verification result. When VerifyStatus is verified, this value is a snippet of the response returned by the target service. When VerifyStatus is failed, this value describes the error cause, such as authentication failure, timeout, or empty response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connectivity verification succeeded</para>
            /// </summary>
            [NameInMap("VerifyMessage")]
            [Validation(Required=false)]
            public string VerifyMessage { get; set; }

            /// <summary>
            /// <para>The current status of the connectivity verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verified</para>
            /// </summary>
            [NameInMap("VerifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
