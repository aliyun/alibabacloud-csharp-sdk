// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsFluctuationResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The input parameter data is not valid. order_storage_company_num component not found</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeTagsFluctuationResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeTagsFluctuationResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Tag name</para>
            /// 
            /// <b>Example:</b>
            /// <para>accountId</para>
            /// </summary>
            [NameInMap("tableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>Data for today</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("todayNum")]
            [Validation(Required=false)]
            public long? TodayNum { get; set; }

            /// <summary>
            /// <para>Data for the last seven days</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("withinSevenDayNum")]
            [Validation(Required=false)]
            public string WithinSevenDayNum { get; set; }

            /// <summary>
            /// <para>Data for the last thirty days</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("withinThirtyDayNum")]
            [Validation(Required=false)]
            public string WithinThirtyDayNum { get; set; }

            /// <summary>
            /// <para>Data for the last three days</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("withinThreeDayNum")]
            [Validation(Required=false)]
            public string WithinThreeDayNum { get; set; }

            /// <summary>
            /// <para>Data for yesterday</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("yesterdayNum")]
            [Validation(Required=false)]
            public long? YesterdayNum { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
