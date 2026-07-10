// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryVerifyInvokeSatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>200</b> indicates a successful response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<QueryVerifyInvokeSatisticResponseBodyItems> Items { get; set; }
        public class QueryVerifyInvokeSatisticResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of statistics data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryVerifyInvokeSatisticResponseBodyItemsData> Data { get; set; }
            public class QueryVerifyInvokeSatisticResponseBodyItemsData : TeaModel {
                /// <summary>
                /// <para>The count of the statistical value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public string StatisticsCount { get; set; }

                /// <summary>
                /// <para>The product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID_PRO</para>
                /// </summary>
                [NameInMap("StatisticsType")]
                [Validation(Required=false)]
                public string StatisticsType { get; set; }

            }

            /// <summary>
            /// <para>The statistics date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16</para>
            /// </summary>
            [NameInMap("StatisticsDate")]
            [Validation(Required=false)]
            public string StatisticsDate { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FA2C773-47DB-4156-B1EE-5B047321A939</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the response is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
