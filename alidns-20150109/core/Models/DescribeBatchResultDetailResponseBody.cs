// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed results of the batch operation.</para>
        /// </summary>
        [NameInMap("BatchResultDetails")]
        [Validation(Required=false)]
        public DescribeBatchResultDetailResponseBodyBatchResultDetails BatchResultDetails { get; set; }
        public class DescribeBatchResultDetailResponseBodyBatchResultDetails : TeaModel {
            [NameInMap("BatchResultDetail")]
            [Validation(Required=false)]
            public List<DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail> BatchResultDetail { get; set; }
            public class DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail : TeaModel {
                /// <summary>
                /// <para>The type of the batch operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOMAIN_ADD</para>
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The line code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// <para>The new hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-batch-7</para>
                /// </summary>
                [NameInMap("NewRr")]
                [Validation(Required=false)]
                public string NewRr { get; set; }

                /// <summary>
                /// <para>The new record value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.254</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <para>The time when the operation was performed. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-22 18:02:58</para>
                /// </summary>
                [NameInMap("OperateDateStr")]
                [Validation(Required=false)]
                public string OperateDateStr { get; set; }

                /// <summary>
                /// <para>The priority of the mail exchanger (MX) record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The cause of the execution failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Task lock fail</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The ID of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <para>The description of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remark</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>www</para>
                /// </summary>
                [NameInMap("Rr")]
                [Validation(Required=false)]
                public string Rr { get; set; }

                /// <summary>
                /// <para>The status of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stop</para>
                /// </summary>
                [NameInMap("RrStatus")]
                [Validation(Required=false)]
                public string RrStatus { get; set; }

                /// <summary>
                /// <para>The execution result of the batch operation. Valid values: <b>true</b>: The operation succeeded. <b>false</b>: The operation failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                /// <summary>
                /// <para>The time-to-live (TTL) of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public string Ttl { get; set; }

                /// <summary>
                /// <para>The type of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the DNS record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75446CC1-FC9A-4595-8D96-089D73D7A63D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
