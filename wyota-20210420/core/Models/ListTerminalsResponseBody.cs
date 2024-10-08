// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListTerminalsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TERMINAL_NOT_FOUND</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTerminalsResponseBodyData> Data { get; set; }
        public class ListTerminalsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DemoDevice</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("BindUserCount")]
            [Validation(Required=false)]
            public int? BindUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.0.2-RS-20240805.044924</para>
            /// </summary>
            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-drqmaogzbmbdf****</para>
            /// </summary>
            [NameInMap("CurrentConnectDesktop")]
            [Validation(Required=false)]
            public string CurrentConnectDesktop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("CurrentLoginUser")]
            [Validation(Required=false)]
            public string CurrentLoginUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Ipv4")]
            [Validation(Required=false)]
            public string Ipv4 { get; set; }

            [NameInMap("LastLoginUser")]
            [Validation(Required=false)]
            public string LastLoginUser { get; set; }

            [NameInMap("LocationInfo")]
            [Validation(Required=false)]
            public string LocationInfo { get; set; }

            [NameInMap("ManageTime")]
            [Validation(Required=false)]
            public string ManageTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>US01</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("PasswordFreeLoginUser")]
            [Validation(Required=false)]
            public string PasswordFreeLoginUser { get; set; }

            [NameInMap("PublicIpv4")]
            [Validation(Required=false)]
            public string PublicIpv4 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ODN49YQCPQYC****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("SetPasswordFreeLoginUserTime")]
            [Validation(Required=false)]
            public string SetPasswordFreeLoginUserTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tg-default</para>
            /// </summary>
            [NameInMap("TerminalGroupId")]
            [Validation(Required=false)]
            public string TerminalGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>04873D3898B51A7DF2455C1E1DC9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>terminal not found</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdEdsXbwG2ZlbWCzN4wTTg6wQvfp7u1BJl4bxCAby41POSaYAlCvfULQpkAnb0ff****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C5DCE54A-B266-522E-A6ED-468AF45F5AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
