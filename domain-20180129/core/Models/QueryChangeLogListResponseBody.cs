// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryChangeLogListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryChangeLogListResponseBodyData Data { get; set; }
        public class QueryChangeLogListResponseBodyData : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<QueryChangeLogListResponseBodyDataChangeLog> ChangeLog { get; set; }
            public class QueryChangeLogListResponseBodyDataChangeLog : TeaModel {
                [NameInMap("Details")]
                [Validation(Required=false)]
                public string Details { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("OperationIPAddress")]
                [Validation(Required=false)]
                public string OperationIPAddress { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether a next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether a previous page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DEDFF32-7827-46B1-BE90-3DB8ABD91A58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The API returns a maximum of 1,000 recent records per query, regardless of the specified page size. If your query matches more than 1,000 records, <b>ResultLimit</b> is <b>true</b>. To retrieve all results, narrow the time range and query again. Otherwise, <b>ResultLimit</b> is <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResultLimit")]
        [Validation(Required=false)]
        public bool? ResultLimit { get; set; }

        /// <summary>
        /// <para>The total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
