// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task flow. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to obtain the ID of the task flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7***</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query the execution records of the task flow. Specify the time in the yyyy-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-07</para>
        /// </summary>
        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the time range to query the execution records of the task flow. Specify the time in the yyyy-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-08</para>
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        /// <summary>
        /// <para>The running status of the task node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Waiting for scheduling</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Running</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Suspend</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Failed to run</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Run successfully</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: Completed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The mode in which the task flow is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The task flow is automatically triggered based on periodic scheduling.</description></item>
        /// <item><description><b>1</b>: The task flow is manually triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public int? TriggerType { get; set; }

        /// <summary>
        /// <para>Adjust filter conditions:</para>
        /// <list type="bullet">
        /// <item><description><para>true: StartTimeBegin and StartTimeEnd are the time range for filtering services.</para>
        /// </description></item>
        /// <item><description><para>false: StartTimeBegin and StartTimeEnd are the time range for the task to run.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseBizDate")]
        [Validation(Required=false)]
        public bool? UseBizDate { get; set; }

    }

}
