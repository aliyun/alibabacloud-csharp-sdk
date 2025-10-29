// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// <para>The advanced settings of the node.</para>
        /// <para>This parameter corresponds to the Advanced Settings section in the right-side navigation pane on the configuration tab of EMR Spark Streaming and EMR Streaming SQL nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>Only EMR Spark Streaming and EMR Streaming SQL nodes support this parameter. The value must be in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;queue&quot;:&quot;default&quot;,&quot;SPARK_CONF&quot;:&quot;--conf spark.driver.memory=2g&quot;}</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public string AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply the scheduling configuration immediately after the file is published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ApplyScheduleImmediately")]
        [Validation(Required=false)]
        public bool? ApplyScheduleImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic parsing for the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Analyze Code setting in Properties &gt; Dependencies for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoParsing")]
        [Validation(Required=false)]
        public bool? AutoParsing { get; set; }

        /// <summary>
        /// <para>The interval at which the node is automatically rerun after a failure. Unit: milliseconds. Maximum value: 1800000 milliseconds (30 minutes).</para>
        /// <para>This parameter corresponds to the Rerun interval parameter in Properties &gt; Schedule &gt; Auto Rerun upon Failure for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. In the console, the unit of the rerun interval is minutes. Convert the time unit when you call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("AutoRerunIntervalMillis")]
        [Validation(Required=false)]
        public int? AutoRerunIntervalMillis { get; set; }

        /// <summary>
        /// <para>The number of automatic reruns after an error occurs. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRerunTimes")]
        [Validation(Required=false)]
        public int? AutoRerunTimes { get; set; }

        /// <summary>
        /// <para>The data source used when the task published from the file is run.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/211432.html">UpdateDataSource</a> operation to query the available data sources in the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_source</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The file code content. Different code types (fileType) have different code formats. In Operation Center, you can find a task of the corresponding type, right-click it, and select View Code to view the specific code format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create the directory specified by FileFolderPath if the directory does not exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: If the directory does not exist, automatically create it.</description></item>
        /// <item><description>false: If the directory does not exist, the call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateFolderIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateFolderIfNotExists { get; set; }

        /// <summary>
        /// <para>The cron expression for scheduled execution. This parameter corresponds to the Cron Expression setting in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure Scheduling Cycle and Scheduled Time, DataWorks automatically generates a cron expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled at 05:30 every day: <c>00 30 05 * * ?</c></description></item>
        /// <item><description>Scheduled at the 15th minute of every hour: <c>00 15 00-23/1 * * ?</c></description></item>
        /// <item><description>Scheduled every 10 minutes: <c>00 00/10 * * * ?</c></description></item>
        /// <item><description>Scheduled every 10 minutes between 08:00 and 17:00 every day: <c>00 00-59/10 8-17 * * * ?</c></description></item>
        /// <item><description>Scheduled at 00:20 on the 1st day of every month: <c>00 20 00 1 * ?</c></description></item>
        /// <item><description>Scheduled every 3 months starting from 00:10 on January 1: <c>00 10 00 1 1-12/3 ?</c></description></item>
        /// <item><description>Scheduled at 00:05 on every Tuesday and Friday: <c>00 05 00 * * 2,5</c></description></item>
        /// </list>
        /// <para>Due to the rules of the DataWorks scheduling system, cron expressions have the following restrictions:</para>
        /// <list type="bullet">
        /// <item><description>The minimum scheduling interval is 5 minutes.</description></item>
        /// <item><description>The earliest scheduling time each day is 00:05.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>00 05 00 * * ?</para>
        /// </summary>
        [NameInMap("CronExpress")]
        [Validation(Required=false)]
        public string CronExpress { get; set; }

        /// <summary>
        /// <para>The type of scheduling cycle. Valid values: NOT_DAY (minute, hour) and DAY (day, week, month).</para>
        /// <para>This parameter corresponds to the Scheduling Cycle setting in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes on which the current node depends. This parameter takes effect only when the DependentType parameter is set to USER_DEFINE. Separate multiple node IDs with commas (,).</para>
        /// <para>This parameter corresponds to the Other Nodes option in Properties &gt; Dependencies &gt; Cross-cycle Dependency (Original Previous-cycle Dependency) for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DependentNodeIdList")]
        [Validation(Required=false)]
        public string DependentNodeIdList { get; set; }

        /// <summary>
        /// <para>The dependency mode on the previous cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: Depends on the current node.</description></item>
        /// <item><description>CHILD: Depends on the child nodes.</description></item>
        /// <item><description>USER_DEFINE: Depends on other nodes.</description></item>
        /// <item><description>NONE: No dependencies. Does not depend on the previous cycle.</description></item>
        /// <item><description>USER_DEFINE_AND_SELF: Depends on both the current node and other nodes in the previous cycle.</description></item>
        /// <item><description>CHILD_AND_SELF: Depends on both the current node and its child nodes in the previous cycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("DependentType")]
        [Validation(Required=false)]
        public string DependentType { get; set; }

        /// <summary>
        /// <para>The timestamp (in milliseconds) when automatic scheduling stops.</para>
        /// <para>This parameter corresponds to the end time of Effective Period in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671694850000</para>
        /// </summary>
        [NameInMap("EndEffectDate")]
        [Validation(Required=false)]
        public long? EndEffectDate { get; set; }

        /// <summary>
        /// <para>The description of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileDescription")]
        [Validation(Required=false)]
        public string FileDescription { get; set; }

        /// <summary>
        /// <para>The file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/MaxCompute/Folder_1/Folder_2</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File name</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The code type of the file. Different file types have different code. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks node types</a>. You can call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the code types of files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// <para>Specifies whether to inherit the dry-run status from the previous cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Inherit the dry-run status from the previous cycle.</description></item>
        /// <item><description>false: Do not inherit the dry-run status from the previous cycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreParentSkipRunningProperty")]
        [Validation(Required=false)]
        public bool? IgnoreParentSkipRunningProperty { get; set; }

        /// <summary>
        /// <para>The custom image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp1h4b5a8ogkbll2f3tr</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The output names of the ancestor nodes on which the current node depends. Separate multiple output names with commas (,).</para>
        /// <para>This parameter corresponds to the Output Name of Ancestor Node setting in Properties &gt; Dependencies for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The input context parameters of the node. The value must be in the JSON format. For more information about the parameter structure, see the InputContextParameterList parameter in the response parameters of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Input Parameters setting in Properties &gt; Input and Output Parameters for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ValueSource&quot;: &quot;project_001.first_node:bizdate_param&quot;,&quot;ParameterName&quot;: &quot;bizdate_input&quot;}]</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        /// <summary>
        /// <para>The output context parameters of the node. The value must be in the JSON format. For more information about the parameter structure, see the OutputContextParameterList parameter in the response parameters of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Output Parameters setting in Properties &gt; Input and Output Parameters for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Type&quot;: 1,&quot;Value&quot;: &quot;${bizdate}&quot;,&quot;ParameterName&quot;: &quot;bizdate_param&quot;}]</para>
        /// </summary>
        [NameInMap("OutputParameters")]
        [Validation(Required=false)]
        public string OutputParameters { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the file owner. If this parameter is not specified, the Alibaba Cloud account ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The scheduling parameters of the node. Separate multiple parameters with spaces.</para>
        /// <para>This parameter corresponds to the Scheduling Parameter setting in Properties for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a=x b=y</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. To obtain the workspace ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace configuration page. You must configure either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace name. To obtain the workspace name, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace configuration page.</para>
        /// <para>You must specify either this parameter or ProjectId to identify the target DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The rerun policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_ALLOWED: Reruns are allowed regardless of whether the task succeeds or fails.</description></item>
        /// <item><description>FAILURE_ALLOWED: Reruns are allowed only when the task fails.</description></item>
        /// <item><description>ALL_DENIED: Reruns are not allowed regardless of whether the task succeeds or fails.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Support for Rerun setting in Scheduling &gt; Scheduling Policies for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>375827434852437</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public long? ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource group for the task published from the file. To obtain the ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, navigate to the workspace configuration page, and click Resource Groups in the left-side navigation pane to view the IDs of resource groups bound to the current workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S_res_group_559_1613715566828</para>
        /// </summary>
        [NameInMap("ResourceGroupIdentifier")]
        [Validation(Required=false)]
        public string ResourceGroupIdentifier { get; set; }

        /// <summary>
        /// <para>The scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Normal scheduled task.</description></item>
        /// <item><description>MANUAL: Manually triggered node. Not scheduled for daily execution. Corresponds to nodes in manually triggered workflows.</description></item>
        /// <item><description>PAUSE: Paused task.</description></item>
        /// <item><description>SKIP: Dry-run task. Scheduled for daily execution but is directly marked as successful when scheduling starts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

        /// <summary>
        /// <para>The timestamp (in milliseconds) when automatic scheduling starts.</para>
        /// <para>This parameter corresponds to the start time of Effective Period in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671608450000</para>
        /// </summary>
        [NameInMap("StartEffectDate")]
        [Validation(Required=false)]
        public long? StartEffectDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately run the node after the node is deployed.</para>
        /// <para>This parameter corresponds to the Start Method setting in Settings &gt; Schedule in the right-side navigation pane on the configuration tab of EMR Spark Streaming and EMR Streaming SQL nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StartImmediately")]
        [Validation(Required=false)]
        public bool? StartImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip execution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Skip Execution option in Properties &gt; Schedule &gt; Recurrence for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

        /// <summary>
        /// <para>The timeout settings for scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
