// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetTerminalCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. 200 is returned if the call is successful. An error code is returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The terminal count statistics information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTerminalCountResponseBodyData Data { get; set; }
        public class GetTerminalCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of hardware terminals that are bound to users. This parameter is returned only when ClientType is set to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("BindUserCount")]
            [Validation(Required=false)]
            public long? BindUserCount { get; set; }

            /// <summary>
            /// <para>The number of managed terminals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("InManageCount")]
            [Validation(Required=false)]
            public long? InManageCount { get; set; }

            /// <summary>
            /// <para>The number of unmanaged terminals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("NotInManageCount")]
            [Validation(Required=false)]
            public long? NotInManageCount { get; set; }

            /// <summary>
            /// <para>The total number of terminals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is empty if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parameter error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DCE54A-B266-522E-A6ED-468AF45F5AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
