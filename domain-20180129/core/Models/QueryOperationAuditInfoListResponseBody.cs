// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryOperationAuditInfoListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryOperationAuditInfoListResponseBodyData> Data { get; set; }
        public class QueryOperationAuditInfoListResponseBodyData : TeaModel {
            [NameInMap("AuditInfo")]
            [Validation(Required=false)]
            public string AuditInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditType")]
            [Validation(Required=false)]
            public int? AuditType { get; set; }

            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1581919010101</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com,aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1581919010101</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-40EC-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>199</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
