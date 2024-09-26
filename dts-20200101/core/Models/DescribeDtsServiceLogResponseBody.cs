// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsServiceLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The dynamic error code. This parameter will be removed soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the \<em>\</em>%s\<em>\</em> variable in the <b>ErrMessage</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of log entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F87DF250-952C-47FE-8A02-69414FAA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the logs.</para>
        /// </summary>
        [NameInMap("ServiceLogContexts")]
        [Validation(Required=false)]
        public List<DescribeDtsServiceLogResponseBodyServiceLogContexts> ServiceLogContexts { get; set; }
        public class DescribeDtsServiceLogResponseBodyServiceLogContexts : TeaModel {
            /// <summary>
            /// <para>The log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Statistics: generator = 369173; collector = 470109; replicator = 2470; ping = 2/2/2; execute = 29/29/29; rt = 29/29/29; state = IDLE; queries = -1; exceptions = {connects = 0, replicates = 0}; infos = {}</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The log level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the logs were collected. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-13T09:13:39.443+00:00</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of logs that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
