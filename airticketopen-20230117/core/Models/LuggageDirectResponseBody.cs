// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class LuggageDirectResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<LuggageDirectResponseBodyData> Data { get; set; }
        public class LuggageDirectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The three-letter IATA code of the city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("city_code")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The luggage through-check rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: luggage through-check is not supported.</description></item>
            /// <item><description>1: luggage through-check is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("direct_type")]
            [Validation(Required=false)]
            public int? DirectType { get; set; }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
