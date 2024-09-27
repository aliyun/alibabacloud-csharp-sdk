// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public DescribeDnsGtmLogsResponseBodyLogs Logs { get; set; }
        public class DescribeDnsGtmLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmLogsResponseBodyLogsLog> Log { get; set; }
            public class DescribeDnsGtmLogsResponseBodyLogsLog : TeaModel {
                /// <summary>
                /// <para>The formatted message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>addtest-pool-1</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The ID of the object on which the operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121212</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The name of the object on which the operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-pool-1</para>
                /// </summary>
                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// <para>The type of the object on which the operation was performed.</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The ID of the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6726</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The operation performed.</para>
                /// </summary>
                [NameInMap("OperAction")]
                [Validation(Required=false)]
                public string OperAction { get; set; }

                /// <summary>
                /// <para>The time when the operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-24T07:35Z</para>
                /// </summary>
                [NameInMap("OperTime")]
                [Validation(Required=false)]
                public string OperTime { get; set; }

                /// <summary>
                /// <para>The timestamp of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1516779348000</para>
                /// </summary>
                [NameInMap("OperTimestamp")]
                [Validation(Required=false)]
                public long? OperTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50C60A29-2E93-425A-ABA8-068686E28873</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned on all pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
