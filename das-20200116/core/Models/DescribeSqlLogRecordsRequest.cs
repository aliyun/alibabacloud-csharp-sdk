// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>A list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSqlLogRecordsRequestFilters> Filters { get; set; }
        public class DescribeSqlLogRecordsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter key.</para>
            /// <remarks>
            /// <para>For details on supported filter keys and their values, see <b>Additional information about request parameters</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>keyWords</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is applicable only to ApsaraDB RDS for MySQL and PolarDB for MySQL cluster instances. If this parameter is omitted, the log details of the primary node are returned by default.</para>
        /// </description></item>
        /// <item><description><para>For PolarDB-X 2.0, set this parameter to <b>polarx_cn</b> (compute node) or <b>polarx_dn</b> (data node).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pi-uf6k5f6g3912i****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role of the node in the PolarDB-X 2.0 database instance.</para>
        /// <list type="bullet">
        /// <item><description><para><b>polarx_cn</b>: compute node.</para>
        /// </description></item>
        /// <item><description><para><b>polarx_dn</b>: data node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
