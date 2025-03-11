// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsSlowSqlsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the details of the slow SQL query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDrdsSlowSqlsResponseBodyItems Items { get; set; }
        public class DescribeDrdsSlowSqlsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeDrdsSlowSqlsResponseBodyItemsItem> Item { get; set; }
            public class DescribeDrdsSlowSqlsResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// <para>Indicates the IP address of the execution machine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.<em><b>.</b></em></para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Indicates the response time. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568267711</para>
                /// </summary>
                [NameInMap("ResponseTime")]
                [Validation(Required=false)]
                public long? ResponseTime { get; set; }

                /// <summary>
                /// <para>Indicates the name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>Indicates the time when the slow SQL query was sent. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568267711</para>
                /// </summary>
                [NameInMap("SendTime")]
                [Validation(Required=false)]
                public long? SendTime { get; set; }

                /// <summary>
                /// <para>Indicates the content of the slow SQL query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT   count(1) from   payment_order where   order_status = \&quot;08\&quot;;</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates the page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Indicates the number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>509BDE17-505A-4B3B-854D-30D3F0******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>Indicates the total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
