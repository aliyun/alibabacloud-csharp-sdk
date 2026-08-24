// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateSqlLogTaskRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the task. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
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
        public List<CreateSqlLogTaskRequestFilters> Filters { get; set; }
        public class CreateSqlLogTaskRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter parameter.</para>
            /// <remarks>
            /// <para>For the supported filter parameters and values, see <b>Request parameters description</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>KeyWords</para>
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
        /// <para>The database instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL audit export 1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to cluster instances. You can specify this parameter to query the batch task of a specific node. If you do not specify this parameter, the batch task of the primary node is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-uf6k5f6g3912i****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The node information of the PolarDB-X 2.0 database instance.</para>
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
        /// <para>The start time of the task. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <list type="bullet">
        /// <item><description><b>Export</b>: export task.<remarks>
        /// <para>For the filter parameters and values supported by <b>Export</b>, see <b>Request parameters description</b>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Query</b>: query task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Export</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
