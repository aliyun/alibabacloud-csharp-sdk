// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of records returned by the query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListTablesResponseBodyItems> Items { get; set; }
        public class ListTablesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The description of the database table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer contact information</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the data object was created. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788566400000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The instance identity of the cloud instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1abcdefgh****</para>
            /// </summary>
            [NameInMap("DataAssetSourceId")]
            [Validation(Required=false)]
            public string DataAssetSourceId { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business_db</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The description of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business database instance</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The name of the database table. Some engines return the name in the schema.table format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the database table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the sensitivity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The list of detection models or rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyItemsRuleList> RuleList { get; set; }
            public class ListTablesResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// <para>The number of hits for the detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The name of the detection model or rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Phone number</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the sensitivity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the data is detected as sensitive data.</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The number of sensitive data entries within the current statistical scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The proportion of sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("SensitiveRatio")]
            [Validation(Required=false)]
            public string SensitiveRatio { get; set; }

            /// <summary>
            /// <para>The name of the tenant to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business tenant</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the current statistical or query scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination cursor used for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The cursor used to query the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the current statistical or query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Indicates whether more pages exist. A value of true indicates that more data exists. A value of false indicates that no more data exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Truncated")]
        [Validation(Required=false)]
        public string Truncated { get; set; }

    }

}
