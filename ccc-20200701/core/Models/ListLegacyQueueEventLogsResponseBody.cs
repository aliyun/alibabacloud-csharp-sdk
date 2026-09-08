// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListLegacyQueueEventLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLegacyQueueEventLogsResponseBodyData Data { get; set; }
        public class ListLegacyQueueEventLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of queue event logs.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListLegacyQueueEventLogsResponseBodyDataList> List { get; set; }
            public class ListLegacyQueueEventLogsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>456328****</para>
                /// </summary>
                [NameInMap("Acid")]
                [Validation(Required=false)]
                public string Acid { get; set; }

                /// <summary>
                /// <para>Calling party</para>
                /// 
                /// <b>Example:</b>
                /// <para>8012****</para>
                /// </summary>
                [NameInMap("Ani")]
                [Validation(Required=false)]
                public string Ani { get; set; }

                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AnswerPhone")]
                [Validation(Required=false)]
                public string AnswerPhone { get; set; }

                /// <summary>
                /// <para>Acknowledgement duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("AnswerTime")]
                [Validation(Required=false)]
                public long? AnswerTime { get; set; }

                /// <summary>
                /// <para>Hang-up reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>正常</para>
                /// </summary>
                [NameInMap("Cause")]
                [Validation(Required=false)]
                public string Cause { get; set; }

                /// <summary>
                /// <para>Dialed number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1312211****</para>
                /// </summary>
                [NameInMap("Dnis")]
                [Validation(Required=false)]
                public string Dnis { get; set; }

                /// <summary>
                /// <para>Primary key</para>
                /// 
                /// <b>Example:</b>
                /// <para>109160</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Queue duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// <para>Statistics date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-03T10:15:30</para>
                /// </summary>
                [NameInMap("StatisticDate")]
                [Validation(Required=false)]
                public string StatisticDate { get; set; }

                /// <summary>
                /// <para>Tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acc3733</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Queue name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("Vq")]
                [Validation(Required=false)]
                public string Vq { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A5A8998-41F9-5F85-BFCF-EB2B6E376812</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the invocation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
