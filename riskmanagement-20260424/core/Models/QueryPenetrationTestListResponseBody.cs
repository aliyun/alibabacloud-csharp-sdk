// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryPenetrationTestListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPenetrationTestListResponseBodyData Data { get; set; }
        public class QueryPenetrationTestListResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryPenetrationTestListResponseBodyDataList> List { get; set; }
            public class QueryPenetrationTestListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public long? ApplyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>710864062</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0.158.58</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>early_end</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("TestEndDate")]
                [Validation(Required=false)]
                public long? TestEndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("TestStartDate")]
                [Validation(Required=false)]
                public long? TestStartDate { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryPenetrationTestListResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryPenetrationTestListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99D93ED4-D462-5FC5-8518-9BC1C49C7B6C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
