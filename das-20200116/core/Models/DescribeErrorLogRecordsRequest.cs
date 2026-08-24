// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeErrorLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. The value is in the format of a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: The value is of the Long type. Precision loss may occur during serialization/deserialization. The value must not be greater than 9007199254740991.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732069466000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// <remarks>
        /// <para>Filtering is supported only for error logs of ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, PolarDB for MySQL, PolarDB for PostgreSQL, and PolarDB for PostgreSQL (Compatible with Oracle).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeErrorLogRecordsRequestFilters> Filters { get; set; }
        public class DescribeErrorLogRecordsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter parameter. Set this parameter to filters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>filters</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The error log content to filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deadlock</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1u5mas9exx7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp16v3824rt73****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The node role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>db</description></item>
        /// <item><description>mongos</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for ApsaraDB for MongoDB instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is in the format of a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: The value is of the Long type. Precision loss may occur during serialization/deserialization. The value must not be greater than 9007199254740991.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731983066000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
