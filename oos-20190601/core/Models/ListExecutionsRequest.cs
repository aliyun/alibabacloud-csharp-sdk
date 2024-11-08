// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The types of the execution template. Valid values: Other, TimerTrigger, EventTrigger, and AlarmTrigger. You can specify only one of the Categories and Category parameters. We recommend that you specify Categories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TimerTrigger&quot;、&quot;EventTrigger&quot;]</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string Categories { get; set; }

        /// <summary>
        /// <para>The type of the execution template. Valid values: Other, TimerTrigger, EventTrigger, and AlarmTrigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Other</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The depth of execution. Valid values: RootDepth and FirstChildDepth. If you set this parameter to RootDepth, only the parent execution is returned. If you set this parameter to FirstChildDepth, only the child executions at the first level are returned. You can specify only one of the Depth and IncludeChildExecution parameters. We recommend that you specify Depth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RootDepth</para>
        /// </summary>
        [NameInMap("Depth")]
        [Validation(Required=false)]
        public string Depth { get; set; }

        /// <summary>
        /// <para>The description of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The earliest end time. The executions that stop running at or later than the specified time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("EndDateAfter")]
        [Validation(Required=false)]
        public string EndDateAfter { get; set; }

        /// <summary>
        /// <para>The latest end time. The executions that stop running at or earlier than the specified time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("EndDateBefore")]
        [Validation(Required=false)]
        public string EndDateBefore { get; set; }

        /// <summary>
        /// <para>The executor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vme</para>
        /// </summary>
        [NameInMap("ExecutedBy")]
        [Validation(Required=false)]
        public string ExecutedBy { get; set; }

        /// <summary>
        /// <para>The ID of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-xxx</para>
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include child executions. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeChildExecution")]
        [Validation(Required=false)]
        public bool? IncludeChildExecution { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 10 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automatic</b></description></item>
        /// <item><description><b>Debug</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automatic</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the parent execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-xxx</para>
        /// </summary>
        [NameInMap("ParentExecutionId")]
        [Validation(Required=false)]
        public string ParentExecutionId { get; set; }

        /// <summary>
        /// <para>The RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OOSServiceRole</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instances you want to query belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Compute Service (ECS) resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-xxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the resource template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS-ECS-TEST</para>
        /// </summary>
        [NameInMap("ResourceTemplateName")]
        [Validation(Required=false)]
        public string ResourceTemplateName { get; set; }

        /// <summary>
        /// <para>The field that is used to sort the executions to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>StartDate</b>: specifies that the executions are sorted based on the time when they are created. This is the default value.</description></item>
        /// <item><description><b>EndDate</b>: specifies that the executions are sorted based on the time when they stop running.</description></item>
        /// <item><description><b>Status</b>: specifies that the executions are sorted based on their states.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StartDate</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ascending</b>: ascending order.</description></item>
        /// <item><description><b>Descending</b>: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The earliest start time. The executions that start to run at or later than the specified time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("StartDateAfter")]
        [Validation(Required=false)]
        public string StartDateAfter { get; set; }

        /// <summary>
        /// <para>The latest start time. The executions that start to run at or earlier than the specified point in time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-16T10:26:14Z</para>
        /// </summary>
        [NameInMap("StartDateBefore")]
        [Validation(Required=false)]
        public string StartDateBefore { get; set; }

        /// <summary>
        /// <para>The status of the execution. Valid values: Running, Started, Success, Failed, Waiting, Cancelled, Pending, and Skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags for the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The name of the template. All templates whose names contain the specified template name are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
