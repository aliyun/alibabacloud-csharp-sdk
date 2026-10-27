// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end time. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSqlLogRecordsRequestFilters> Filters { get; set; }
        public class DescribeSqlLogRecordsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter parameter.</para>
            /// <remarks>
            /// <para>For supported filter parameters and their valid values, refer to <b>Supplementary request parameter descriptions</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>keyWords</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter parameter.</para>
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
        /// <item><description>For ApsaraDB RDS for MySQL and PolarDB for MySQL, this parameter applies only to Cluster Edition instances. If you do not specify this parameter, the log details of the primary node are queried by default.</description></item>
        /// <item><description>For PolarDB-X 2.0, set this parameter to <b>polarx_cn</b> (compute node) or <b>polarx_dn</b> (data node).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pi-uf6k5f6g3912i****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number for paging. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role of the node in the PolarDB-X 2.0 instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx_cn</b>: compute node.</description></item>
        /// <item><description><b>polarx_dn</b>: data node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
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
