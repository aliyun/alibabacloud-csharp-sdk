// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeErrorLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This field is of the Long type. During serialization and deserialization, precision may be lost. Make sure that the value does not exceed 9007199254740991.</para>
        /// </notice>
        /// 
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
        /// <para>Error log filtering is supported only for RDS MySQL, RDS PostgreSQL, PolarDB for MySQL, PolarDB for PostgreSQL, and PolarDB for PostgreSQL (compatible with Oracle).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeErrorLogRecordsRequestFilters> Filters { get; set; }
        public class DescribeErrorLogRecordsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter parameter. Set the value to filters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>filters</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The content of the error log to filter.</para>
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
        /// <para>The node role:</para>
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
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This field is of the Long type. During serialization and deserialization, precision may be lost. Make sure that the value does not exceed 9007199254740991.</para>
        /// </notice>
        /// 
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
