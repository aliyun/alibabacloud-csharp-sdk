// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListViberServiceMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request is successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListViberServiceMessageResponseBodyData> Data { get; set; }
        public class ListViberServiceMessageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("BusinessAccountName")]
            [Validation(Required=false)]
            public string BusinessAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the destination country or region.</para>
            /// </summary>
            [NameInMap("DestinationCountryId")]
            [Validation(Required=false)]
            public List<string> DestinationCountryId { get; set; }

            /// <summary>
            /// <para>The ID of the destination country or region.</para>
            /// </summary>
            [NameInMap("DestinationInternationalCountryId")]
            [Validation(Required=false)]
            public List<string> DestinationInternationalCountryId { get; set; }

            /// <summary>
            /// <para>The involved industry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Healthcare</para>
            /// </summary>
            [NameInMap("IndustryInvolved")]
            [Validation(Required=false)]
            public string IndustryInvolved { get; set; }

            /// <summary>
            /// <para>The collection of destination countries or regions.</para>
            /// </summary>
            [NameInMap("MessageDestinationCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationCountry { get; set; }

            /// <summary>
            /// <para>The list of international destination countries or regions.</para>
            /// </summary>
            [NameInMap("MessageDestinationInternationalCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationInternationalCountry { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25644</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues when errors occur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddhjdn-dnjdnkdjknd**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
