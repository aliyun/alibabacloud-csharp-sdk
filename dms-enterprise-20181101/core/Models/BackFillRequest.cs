// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class BackFillRequest : TeaModel {
        /// <summary>
        /// <para>The running sequence of task flows for data backfill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: reverse chronological order.</description></item>
        /// <item><description><b>1</b>: chronological order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The date for the data to be backfilled. This parameter is required if you specify a date for data backfill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14</para>
        /// </summary>
        [NameInMap("BackFillDate")]
        [Validation(Required=false)]
        public string BackFillDate { get; set; }

        /// <summary>
        /// <para>The start date of the date range for the data to be backfilled. This parameter is required if you specify a date range for data backfill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14</para>
        /// </summary>
        [NameInMap("BackFillDateBegin")]
        [Validation(Required=false)]
        public string BackFillDateBegin { get; set; }

        /// <summary>
        /// <para>The end date of the date range for the data to be backfilled. This parameter is required if you specify a date range for data backfill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-29</para>
        /// </summary>
        [NameInMap("BackFillDateEnd")]
        [Validation(Required=false)]
        public string BackFillDateEnd { get; set; }

        /// <summary>
        /// <para>The ID of the task flow. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to query the task flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15***</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>Filter condition, which specifies the list of node IDs in the task flow that do not need to supplement data.</para>
        /// </summary>
        [NameInMap("FilterNodeIds")]
        [Validation(Required=false)]
        public List<long?> FilterNodeIds { get; set; }

        /// <summary>
        /// <para>The ID of the historical task flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16***</para>
        /// </summary>
        [NameInMap("HistoryDagId")]
        [Validation(Required=false)]
        public long? HistoryDagId { get; set; }

        /// <summary>
        /// <para>The interval at which data backfill is performed. Unit: hours. Minimum value: 1. Default value: 24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>Specifies whether to run descendant nodes. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTriggerSubTree")]
        [Validation(Required=false)]
        public bool? IsTriggerSubTree { get; set; }

        /// <summary>
        /// <para>The number of nodes for which you want to backfill data.</para>
        /// </summary>
        [NameInMap("StartNodeIds")]
        [Validation(Required=false)]
        public List<long?> StartNodeIds { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
