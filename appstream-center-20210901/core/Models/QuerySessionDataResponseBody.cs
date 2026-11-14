// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QuerySessionDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. It is empty when the request is successful and data is found. NO_DATA is returned when the query result is empty. If the request fails, the corresponding error code is returned, such as InvalidParameter.DateFormat when the format of the statistical parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NO_DATA</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of session trend data, sorted in ascending order by hour and minute. An empty array is returned when there is no session data on the specified date, and the return code is NO_DATA.</para>
        /// </summary>
        [NameInMap("IndexData")]
        [Validation(Required=false)]
        public List<QuerySessionDataResponseBodyIndexData> IndexData { get; set; }
        public class QuerySessionDataResponseBodyIndexData : TeaModel {
            /// <summary>
            /// <para>The hour to which the session data belongs, with a value range of 00-23 (full hours).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Hh")]
            [Validation(Required=false)]
            public string Hh { get; set; }

            /// <summary>
            /// <para>The minute to which the session data belongs, aggregated in 10-minute intervals, with a value range of 00-50 (namely 00, 10, 20, 30, 40, and 50).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Mi")]
            [Validation(Required=false)]
            public string Mi { get; set; }

            /// <summary>
            /// <para>The aggregated session count within the hour and minute interval (10-minute granularity).</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("SessionCntMi")]
            [Validation(Required=false)]
            public long? SessionCntMi { get; set; }

            /// <summary>
            /// <para>The statistical date to which the session data belongs, in the yyyyMMdd format, consistent with the request parameter StatDate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20261106</para>
            /// </summary>
            [NameInMap("StatDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

        }

        /// <summary>
        /// <para>The return message. It is empty when the request is successful. If the request fails, the corresponding error description is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter DateFormat is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, used to locate call records and troubleshoot issues. The example shows a partially desensitized value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4A13D91-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
