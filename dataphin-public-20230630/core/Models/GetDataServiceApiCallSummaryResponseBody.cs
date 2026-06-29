// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceApiCallSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The aggregate statistics of API calls.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiCallSummaryResponseBodyData Data { get; set; }
        public class GetDataServiceApiCallSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of API calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021</para>
            /// </summary>
            [NameInMap("CallCount")]
            [Validation(Required=false)]
            public long? CallCount { get; set; }

            /// <summary>
            /// <para>The number of APIs with call errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ErrorApiCount")]
            [Validation(Required=false)]
            public long? ErrorApiCount { get; set; }

            /// <summary>
            /// <para>The number of applications affected by errors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ErrorAppCount")]
            [Validation(Required=false)]
            public long? ErrorAppCount { get; set; }

            /// <summary>
            /// <para>The number of failed calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102</para>
            /// </summary>
            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// <para>The error rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.01</para>
            /// </summary>
            [NameInMap("ErrorRate")]
            [Validation(Required=false)]
            public double? ErrorRate { get; set; }

            /// <summary>
            /// <para>The offline percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.03</para>
            /// </summary>
            [NameInMap("OfflineRate")]
            [Validation(Required=false)]
            public double? OfflineRate { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
