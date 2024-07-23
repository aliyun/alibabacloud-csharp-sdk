// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateSqlLogTaskRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<CreateSqlLogTaskRequestFilters> Filters { get; set; }
        public class CreateSqlLogTaskRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter parameter.</para>
            /// <remarks>
            /// <para> For more information about the supported filter parameters and their valid values, see the following <b>supplement about the Key parameter</b>.</para>
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
        /// <para>The ID of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> This parameter is available only for instances that run in a cluster architecture. You can specify this parameter to query the offline tasks of a specific node. By default, if this parameter is not specified, the information about the offline tasks of the primary node is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-uf6k5f6g3912i0dqz</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The role of the node of the PolarDB-X 2.0 database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx_cn</b>: compute node</description></item>
        /// <item><description><b>polarx_dn</b>: data node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1596177993000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Export</b></description></item>
        /// <item><description><b>Query</b></description></item>
        /// <item><description><b>Insight</b></description></item>
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
