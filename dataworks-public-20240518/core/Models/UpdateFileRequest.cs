// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateFileRequest : TeaModel {
        /// <summary>
        /// <para>The advanced settings of the task.</para>
        /// <para>This parameter corresponds to the Advanced Settings section in the right-side navigation pane of the edit page for EMR Spark Streaming and EMR Streaming SQL data development tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>Currently, only EMR Spark Streaming and EMR Streaming SQL tasks support this parameter, and the parameter value must be in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;queue&quot;:&quot;default&quot;,&quot;SPARK_CONF&quot;:&quot;--conf spark.driver.memory=2g&quot;}</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public string AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether the scheduling configuration takes effect immediately after the file is published.</para>
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
        /// <item><description>true: The file automatically parses code.</description></item>
        /// <item><description>false: The file does not automatically parse code.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Code Parsing parameter in the Schedule &gt; Scheduling Dependencies section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoParsing")]
        [Validation(Required=false)]
        public bool? AutoParsing { get; set; }

        /// <summary>
        /// <para>The interval between automatic reruns after a failure, in milliseconds. The maximum value is 1800000, which indicates 30 minutes.</para>
        /// <para>This parameter corresponds to the Rerun Interval parameter in the Schedule &gt; Time Attributes &gt; Auto Rerun upon Failure section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. The unit of the Rerun Interval parameter in the console is minutes. Convert the time unit when you call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("AutoRerunIntervalMillis")]
        [Validation(Required=false)]
        public int? AutoRerunIntervalMillis { get; set; }

        /// <summary>
        /// <para>The number of automatic reruns allowed after an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRerunTimes")]
        [Validation(Required=false)]
        public int? AutoRerunTimes { get; set; }

        /// <summary>
        /// <para>The identifier of the data source used when the task corresponding to the file is executed. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to obtain the list of available data sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_source</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The code content of the file. The code format varies based on the file type. You can go to Operation Center, right-click a task of the corresponding type, and select View Code to view the specific code format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT &quot;1&quot;;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The cron expression for periodic scheduling. This parameter corresponds to the cron expression in the Schedule &gt; Time Property section for the data development task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure the scheduling cycle and timed scheduling time, DataWorks automatically generates the corresponding cron expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Schedule a task at 05:30 every day: <c>00 30 05 * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule a task at the 15th minute of every hour: <c>00 15 * * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule a task every 10 minutes: <c>00 00/10 * * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule a task every 10 minutes from 08:00 to 17:00 every day: <c>00 00-59/10 8-23 * * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule a task at 00:20 on the first day of every month: <c>00 20 00 1 * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule a task every three months starting from 00:10 on January 1: <c>00 10 00 1 1-12/3 ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule a task at 00:05 every Tuesday and Friday: <c>00 05 00 * * 2,5</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>Due to the rules of the DataWorks scheduling system, cron expressions have the following limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The minimum scheduling interval is 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>The earliest scheduling time of a day is 00:05.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>00 00-59/5 1-23 * * ?</para>
        /// </summary>
        [NameInMap("CronExpress")]
        [Validation(Required=false)]
        public string CronExpress { get; set; }

        /// <summary>
        /// <para>The type of the scheduling cycle. Valid values: NOT_DAY (minutes and hours) and DAY (days, weeks, and months).</para>
        /// <para>This parameter corresponds to the Schedule Type parameter in the Schedule &gt; Time Attributes section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes on which the current file depends when the parameter settings of DependentType are set to USER_DEFINE. Separate multiple node IDs with commas (,).</para>
        /// <para>This parameter corresponds to the content configured when you set the Dependency parameter to Cross-cycle Dependency (Previous Cycle) and select Other Nodes in the Schedule &gt; Scheduling Dependencies section for the data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,10,15,20</para>
        /// </summary>
        [NameInMap("DependentNodeIdList")]
        [Validation(Required=false)]
        public string DependentNodeIdList { get; set; }

        /// <summary>
        /// <para>The dependency on the previous cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: The current node.</description></item>
        /// <item><description>CHILD: The child nodes at the first level.</description></item>
        /// <item><description>USER_DEFINE: Other nodes.</description></item>
        /// <item><description>NONE: No dependency on the previous cycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINE</para>
        /// </summary>
        [NameInMap("DependentType")]
        [Validation(Required=false)]
        public string DependentType { get; set; }

        /// <summary>
        /// <para>The end time of automatic scheduling, in the form of a millisecond timestamp.</para>
        /// <para>This parameter corresponds to the end time in the Schedule &gt; Time Attributes &gt; Effective Date section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4155787800000</para>
        /// </summary>
        [NameInMap("EndEffectDate")]
        [Validation(Required=false)]
        public long? EndEffectDate { get; set; }

        /// <summary>
        /// <para>The description of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Here is the file description</para>
        /// </summary>
        [NameInMap("FileDescription")]
        [Validation(Required=false)]
        public string FileDescription { get; set; }

        /// <summary>
        /// <para>The path where the file is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/data_integration/Folder_1/Folder_2</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The ID of the file. You can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to obtain the file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The name of the file. You can change the file name by resetting the value of FileName. For example, you can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to query the ID of a file in the destination directory, call the <a href="https://help.aliyun.com/document_detail/173951.html">UpdateFile</a> operation, specify the queried file ID in the FileId parameter, and configure the FileName parameter to change the name of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_user_info_d</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>This parameter corresponds to the Skip Dry Run of Upstream Nodes parameter that is configured when you set the Dependency parameter to Cross-cycle Dependency (Previous Cycle) and select Current Node or Child Nodes at First Level in the Schedule &gt; Scheduling Dependencies section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreParentSkipRunningProperty")]
        [Validation(Required=false)]
        public bool? IgnoreParentSkipRunningProperty { get; set; }

        /// <summary>
        /// <para>The ID of the custom image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-uf6d7npxk1hhek8ng0cb</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The output names of the upstream files on which the current file depends. Separate multiple output names with commas (,).</para>
        /// <para>This parameter corresponds to the Output Name of Upstream Node parameter in the Schedule &gt; Scheduling Dependencies section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a offline synchronization task by calling the CreateDISyncTask or UpdateFile operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The context input parameters of the node. The parameter value is in JSON format. For the included fields, refer to the InputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Input Parameters of Current Node parameter in the Schedule &gt; Node Context Parameters section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ValueSource&quot;: &quot;project_001.first_node:bizdate_param&quot;,&quot;ParameterName&quot;: &quot;bizdate_input&quot;}]</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        /// <summary>
        /// <para>The output of the file.</para>
        /// <para>This parameter corresponds to the Output Name of Current Node parameter in the Schedule &gt; Scheduling Dependencies section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project.ods_user_info_d</para>
        /// </summary>
        [NameInMap("OutputList")]
        [Validation(Required=false)]
        public string OutputList { get; set; }

        /// <summary>
        /// <para>The context output parameters of the node. The parameter value is in JSON format. For the included fields, refer to the OutputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Output Parameters of Current Node parameter in the Schedule &gt; Node Context Parameters section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Type&quot;: 1,&quot;Value&quot;: &quot;${bizdate}&quot;,&quot;ParameterName&quot;: &quot;bizdate_param&quot;}]</para>
        /// </summary>
        [NameInMap("OutputParameters")]
        [Validation(Required=false)]
        public string OutputParameters { get; set; }

        /// <summary>
        /// <para>The user ID of the file owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18023848927592</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The scheduling parameters.</para>
        /// <para>This parameter corresponds to the Scheduling Parameters section in the Schedule section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a y=b z=c</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can logon to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Settings page to obtain the workspace name.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for this API call.</para>
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
        /// <item><description>ALL_ALLOWED: The task can be rerun regardless of whether it is successfully run or fails to run.</description></item>
        /// <item><description>FAILURE_ALLOWED: The task can be rerun only after it fails to run.</description></item>
        /// <item><description>ALL_DENIED: The task cannot be rerun regardless of whether it is successfully run or fails to run.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Rerun Mode parameter in the Schedule &gt; Time Attributes section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The resource group used when the task is executed after the file is published as a task. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to obtain the list of available resource groups in the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default_group</para>
        /// </summary>
        [NameInMap("ResourceGroupIdentifier")]
        [Validation(Required=false)]
        public string ResourceGroupIdentifier { get; set; }

        /// <summary>
        /// <para>The scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Normal scheduling task.</description></item>
        /// <item><description>MANUAL: Manual task. It is not scheduled on a daily basis and corresponds to a node in a manual workflow.</description></item>
        /// <item><description>PAUSE: Paused task.</description></item>
        /// <item><description>SKIP: Dry-run task. It is scheduled on a daily basis, but its status is directly set to successful when the scheduling is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

        /// <summary>
        /// <para>The start time of automatic scheduling, in the form of a millisecond timestamp.</para>
        /// <para>This parameter corresponds to the start time in the Schedule &gt; Time Attributes &gt; Effective Date section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>936923400000</para>
        /// </summary>
        [NameInMap("StartEffectDate")]
        [Validation(Required=false)]
        public long? StartEffectDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to start the task immediately after it is published. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Start the task immediately after it is published.</description></item>
        /// <item><description>false: Do not start the task immediately after it is published.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Startup Method parameter in the Configuration &gt; Time Attributes section in the right-side navigation pane of the edit page for EMR Spark Streaming and EMR Streaming SQL data development tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>This parameter corresponds to the Pause Scheduling option in the Schedule &gt; Time Attributes &gt; Schedule Type section of the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
