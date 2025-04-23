// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListServerlessJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the E-HPC cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The list of serverless job IDs or subtask IDs (array jobs).</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// <para>The names of the serverless jobs.</para>
        /// </summary>
        [NameInMap("JobNames")]
        [Validation(Required=false)]
        public List<string> JobNames { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/188593.html">ListRegions</a> operation to query the list of regions where E-HPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the serverless jobs by the job start time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order.</description></item>
        /// <item><description>Desc: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("StartOrder")]
        [Validation(Required=false)]
        public string StartOrder { get; set; }

        /// <summary>
        /// <para>The status of the serverless job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>All</description></item>
        /// <item><description>Pending</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Succeeded</description></item>
        /// <item><description>Canceled</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// <para>Default value: All.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the serverless jobs by the job submission time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order.</description></item>
        /// <item><description>Desc: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SubmitOrder")]
        [Validation(Required=false)]
        public string SubmitOrder { get; set; }

        /// <summary>
        /// <para>The latest time at which the job is submitted.</para>
        /// <remarks>
        /// <para> You can use this parameter to query the job list based on the job submission time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1659521430</para>
        /// </summary>
        [NameInMap("SubmitTimeEnd")]
        [Validation(Required=false)]
        public string SubmitTimeEnd { get; set; }

        /// <summary>
        /// <para>The earliest time at which the job is submitted.</para>
        /// <remarks>
        /// <para> You can use this parameter to query the job list based on the job submission time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1647427667</para>
        /// </summary>
        [NameInMap("SubmitTimeStart")]
        [Validation(Required=false)]
        public string SubmitTimeStart { get; set; }

    }

}
