// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// <para>The advanced settings of the task.</para>
        /// <para>This parameter corresponds to the <b>Advanced Settings</b> section in the right-side navigation pane of the edit page for EMR Spark Streaming and EMR Streaming SQL data development tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>Currently, only EMR Spark Streaming and EMR Streaming SQL tasks support this parameter, and the value must be in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;queue&quot;:&quot;default&quot;,&quot;SPARK_CONF&quot;:&quot;--conf spark.driver.memory=2g&quot;}</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public string AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether the scheduling configuration takes effect immediately after deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ApplyScheduleImmediately")]
        [Validation(Required=false)]
        public bool? ApplyScheduleImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic parsing feature for the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The file automatically parses the code.</description></item>
        /// <item><description>false: The file does not automatically parse the code.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the <b>Code Parsing</b> setting when <b>Same Cycle</b> is selected in <b>Schedule Configuration &gt; Scheduling Dependencies</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoParsing")]
        [Validation(Required=false)]
        public bool? AutoParsing { get; set; }

        /// <summary>
        /// <para>The interval between automatic reruns after an error occurs. Unit: milliseconds. Maximum value: 1800000, which indicates 30 minutes.</para>
        /// <para>This parameter corresponds to the <b>Rerun Interval</b> setting in <b>Schedule Configuration &gt; Time Attributes &gt; Automatic Rerun after Error</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.
        /// The time unit for the <b>Rerun Interval</b> setting in the console is minutes. Make sure to convert the time when you call this operation.</para>
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
        /// <para>The data source connected when the task is run after the file is deployed.
        /// You can call the <a href="https://help.aliyun.com/document_detail/211432.html">UpdateDataSource</a> operation to obtain the list of available data sources for the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_source</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The code content of the file. The code format varies based on the file type. You can find a task of the corresponding type in Operation Center, right-click the task, and select View Code to view the specific code format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of the directory specified by the FileFolderPath parameter if it does not exist in the system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables automatic creation of the directory if it does not exist.</description></item>
        /// <item><description>false: The call fails if the directory does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateFolderIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateFolderIfNotExists { get; set; }

        /// <summary>
        /// <para>The cron expression for periodic scheduling. This parameter corresponds to the <b>cron Expression</b> setting in <b>Schedule Configuration &gt; Time Property &gt; cron Expression</b> for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure the <b>Schedule Cycle</b> and <b>timed scheduling</b> time, DataWorks automatically generates the corresponding cron expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Schedule the task at 05:30 every day: <c>00 30 05 * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule the task at the 15th minute of every hour: <c>00 15 00-23/1 * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule the task every 10 minutes: <c>00 00/10 * * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule the task every 10 minutes from 08:00 to 17:00 every day: <c>00 00-59/10 8-17 * * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule the task at 00:20 on the first day of every month: <c>00 20 00 1 * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule the task every three months starting from 00:10 on January 1: <c>00 10 00 1 1-12/3 ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule the task at 00:05 every Tuesday and Friday: <c>00 05 00 * * 2,5</c></para>
        /// </description></item>
        /// </list>
        /// <para>Due to the rules of the DataWorks scheduling system, the cron expression has the following limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The minimum scheduling interval is 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>The earliest scheduling time of a day is 00:05.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>00 05 00 * * ?</para>
        /// </summary>
        [NameInMap("CronExpress")]
        [Validation(Required=false)]
        public string CronExpress { get; set; }

        /// <summary>
        /// <para>The type of the scheduling cycle. Valid values: NOT_DAY (minute or hour) and DAY (day, week, or month).</para>
        /// <para>This parameter corresponds to the <b>Schedule Cycle</b> setting in <b>Schedule Configuration &gt; Time Attributes &gt; Schedule Cycle</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The list of nodes that the current node depends on in the previous cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DependentNodeIdList")]
        [Validation(Required=false)]
        public string DependentNodeIdList { get; set; }

        /// <summary>
        /// <para>The dependency on the previous cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: Depends on the current node.</description></item>
        /// <item><description>CHILD: Depends on the first-level child nodes.</description></item>
        /// <item><description>USER_DEFINE: Depends on other nodes.</description></item>
        /// <item><description>NONE: Does not depend on the previous cycle.   </description></item>
        /// <item><description>USER_DEFINE_AND_SELF: Depends on a combination of the current node and other nodes across cycles.</description></item>
        /// <item><description>CHILD_AND_SELF: Depends on a combination of the first-level child nodes and the current node across cycles.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("DependentType")]
        [Validation(Required=false)]
        public string DependentType { get; set; }

        /// <summary>
        /// <para>The timestamp in milliseconds when automatic scheduling stops.</para>
        /// <para>This parameter corresponds to the end time in the <b>Effective Date</b> setting in <b>Schedule Configuration &gt; Time Attributes &gt; Effective Date</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. The value is a timestamp in milliseconds.</para>
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
        /// <para>This is the file description</para>
        /// </summary>
        [NameInMap("FileDescription")]
        [Validation(Required=false)]
        public string FileDescription { get; set; }

        /// <summary>
        /// <para>The path of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/MaxCompute/Folder_1/Folder_2</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File name</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The code type of the file.
        /// The code format varies based on the file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks node types</a>.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the code type of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// <para>Specifies whether to inherit the dry-run property from the previous cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Inherit the dry-run property from the previous cycle.</para>
        /// </description></item>
        /// <item><description><para>false: Do not inherit the dry-run property from the previous cycle.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreParentSkipRunningProperty")]
        [Validation(Required=false)]
        public bool? IgnoreParentSkipRunningProperty { get; set; }

        /// <summary>
        /// <para>The ID of the custom image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp1h4b5a8ogkbll2f3tr</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The output names of the upstream files on which the current file depends. Separate multiple output names with commas (,).</para>
        /// <para>This parameter corresponds to the <b>Parent Node Output Name</b> setting when <b>Same Cycle</b> is selected in <b>Schedule Configuration &gt; Scheduling Dependencies</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The context input parameters of the node. The value is in JSON format. For the included fields, refer to the InputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the <b>Input Parameters of Current Node</b> setting in <b>Schedule Configuration &gt; Node Context</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ValueSource&quot;: &quot;project_001.first_node:bizdate_param&quot;,&quot;ParameterName&quot;: &quot;bizdate_input&quot;}]</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        /// <summary>
        /// <para>The output names of the file. Separate multiple output names with commas (,). This parameter corresponds to the <b>Output Name of Current Node</b> setting in <b>Schedule Configuration &gt; Scheduling Dependencies</b> for a data development task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("OutputList")]
        [Validation(Required=false)]
        public string OutputList { get; set; }

        /// <summary>
        /// <para>The context output parameters of the node. The value is in JSON format. For the included fields, refer to the OutputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the <b>Output Parameters of Current Node</b> setting in <b>Schedule Configuration &gt; Node Context</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Type&quot;: 1,&quot;Value&quot;: &quot;${bizdate}&quot;,&quot;ParameterName&quot;: &quot;bizdate_param&quot;}]</para>
        /// </summary>
        [NameInMap("OutputParameters")]
        [Validation(Required=false)]
        public string OutputParameters { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud user ID of the file owner. If this parameter is left empty, the Alibaba Cloud user ID of the caller is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The scheduling parameters. Separate multiple parameters with spaces. </para>
        /// <para>This parameter corresponds to the <b>Parameters</b> setting in <b>Schedule Configuration &gt; Parameters</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a=x b=y</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace ID.</para>
        /// <para>You must specify either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace for this API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace name.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for this API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The rerun mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_ALLOWED: The task can be rerun after it succeeds or fails.</description></item>
        /// <item><description>FAILURE_ALLOWED: The task cannot be rerun after it succeeds, but can be rerun after it fails.</description></item>
        /// <item><description>ALL_DENIED: The task cannot be rerun after it succeeds or fails.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the <b>Rerun Mode</b> setting in <b>Schedule Configuration &gt; Time Attributes &gt; Rerun Mode</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Do not use this parameter.</para>
        /// <para>The resource group used to run the task after the file is deployed. This parameter corresponds to the <b>Schedule Resource Group</b> setting in <b>Schedule Configuration &gt; Resource Attributes</b> on the page. You can specify either this parameter or the ResourceGroupIdentifier parameter.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to obtain the list of available resource groups for the workspace. Set ResourceGroupType to 1 and obtain the ID field from the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>375827434852437</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public long? ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource group used to run the task after the file is deployed. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation and obtain the list of available resource groups for the workspace from the <b>identifier</b> field.</para>
        /// <remarks>
        /// <para>Make sure that the resource groups returned by the ListResourceGroups operation are bound to the workspace where the file is created. Only bound resource groups can be used in the CreateFile operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>group_375827434852437</para>
        /// </summary>
        [NameInMap("ResourceGroupIdentifier")]
        [Validation(Required=false)]
        public string ResourceGroupIdentifier { get; set; }

        /// <summary>
        /// <para>The scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Normal scheduling task.</description></item>
        /// <item><description>MANUAL: Manual task. It is not run on a daily schedule and corresponds to a node in a manual workflow.</description></item>
        /// <item><description>PAUSE: Paused task.</description></item>
        /// <item><description>SKIP: Dry-run task. It is run on a daily schedule, but its status is directly set to successful when the scheduling is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

        /// <summary>
        /// <para>The timestamp in milliseconds when automatic scheduling starts.</para>
        /// <para>This parameter corresponds to the start time in the <b>Effective Date</b> setting in <b>Schedule Configuration &gt; Time Attributes &gt; Effective Date</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671608450000</para>
        /// </summary>
        [NameInMap("StartEffectDate")]
        [Validation(Required=false)]
        public long? StartEffectDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to start the task immediately after it is deployed.</para>
        /// <para>This parameter corresponds to the <b>Startup Method</b> setting in <b>Configuration &gt; Time Attributes &gt; Startup Method</b> in the right-side navigation pane of the edit page for EMR Spark Streaming and EMR Streaming SQL data development tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StartImmediately")]
        [Validation(Required=false)]
        public bool? StartImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause scheduling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Pause scheduling.</description></item>
        /// <item><description>false: Do not pause scheduling.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the <b>Pause Scheduling</b> option in <b>Schedule Configuration &gt; Time Attributes &gt; Schedule Type</b> for a data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

        /// <summary>
        /// <para>The timeout definition in the scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
