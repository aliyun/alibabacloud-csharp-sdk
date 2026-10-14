// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class TestAgenticDataSourceConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection test result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestAgenticDataSourceConnectionResponseBodyData Data { get; set; }
        public class TestAgenticDataSourceConnectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the connection test result. This parameter is usually empty when the connection is successful, and returns the cause when the connection fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connection timed out. Check the connection endpoint</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the data source is connected.</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the call fails. This parameter is empty when the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails. This parameter is empty when the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter is invalid</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate the current call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current call is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
