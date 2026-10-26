// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListColumnsResponseBody : TeaModel {
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
        /// <para>The list of records returned by the current query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListColumnsResponseBodyItems> Items { get; set; }
        public class ListColumnsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The creation time of the data object. The value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788566400000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The cloud instance identity.</para>
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
            /// <para>The data type of the database column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The type of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The instance identity of the cloud instance to which the column belongs. This is a compatible field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1abcdefgh****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The compatibility field for the column encryption status. To query column encryption results, call ListDataMaskingColumns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaskingStatus")]
            [Validation(Required=false)]
            public int? MaskingStatus { get; set; }

            /// <summary>
            /// <para>The name of the data column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The ID of the region where the asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The identifier of the detection result correction record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("RevisionId")]
            [Validation(Required=false)]
            public long? RevisionId { get; set; }

            /// <summary>
            /// <para>The correction status of the detection result. Valid values: 0: Not corrected. 1: Corrected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RevisionStatus")]
            [Validation(Required=false)]
            public long? RevisionStatus { get; set; }

            /// <summary>
            /// <para>The identifier of the sensitivity level.</para>
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
            /// <para>The identifier of the matched detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the matched detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Phone number</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The name of the database schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>Indicates whether the data is detected as sensitive data.</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The name of the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page in the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to locate the current API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the current statistics or query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
