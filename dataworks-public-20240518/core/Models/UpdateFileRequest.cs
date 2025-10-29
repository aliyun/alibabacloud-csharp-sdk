// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateFileRequest : TeaModel {
        /// <summary>
        /// <para>The advanced settings for the task.</para>
        /// <para>This parameter corresponds to the Advanced Settings in the right-side navigation pane on the editing page for EMR Spark Streaming and EMR Streaming SQL tasks in Data Studio in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>Currently, only EMR Spark Streaming and EMR Streaming SQL tasks support this parameter, and the parameter must be in JSON format.</para>
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
        /// <para>The number of automatic reruns after the file execution fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRerunTimes")]
        [Validation(Required=false)]
        public int? AutoRerunTimes { get; set; }

        /// <summary>
        /// <para>The name of the data source that is used to run the node. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the available data sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_source</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The file code content. Different code types (fileType) have different code formats. In Operation Center, you can right-click a task of the corresponding type and select View Code to view the specific code format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT &quot;1&quot;;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The cron expression for scheduled execution. This parameter corresponds to the Cron Expression setting in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure Scheduling Cycle and Scheduled Time, DataWorks automatically generates a cron expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled at 05:30 every day: <c>00 30 05 * * ?</c></description></item>
        /// <item><description>Scheduled at the 15th minute of every hour: <c>00 15 * * * ?</c></description></item>
        /// <item><description>Scheduled every 10 minutes: <c>00 00/10 * * * ?</c></description></item>
        /// <item><description>Scheduled every 10 minutes between 08:00 and 23:00 every day: <c>00 00-59/10 8-23 * * * ?</c></description></item>
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
        /// <para>00 00-59/5 1-23 * * ?</para>
        /// </summary>
        [NameInMap("CronExpress")]
        [Validation(Required=false)]
        public string CronExpress { get; set; }

        /// <summary>
        /// <para>The type of scheduling cycle. Valid values: NOT_DAY (minute, hour) and DAY (day, week, month).</para>
        /// <para>This parameter corresponds to the Scheduling Cycle setting in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes on which the current node depends. This parameter takes effect only when the DependentType parameter is set to USER_DEFINE. Separate multiple node IDs with commas (,).</para>
        /// <para>This parameter corresponds to the Other Nodes option in Properties &gt; Dependencies &gt; Cross-cycle Dependency (Original Previous-cycle Dependency) for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,10,15,20</para>
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
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINE</para>
        /// </summary>
        [NameInMap("DependentType")]
        [Validation(Required=false)]
        public string DependentType { get; set; }

        /// <summary>
        /// <para>The timestamp (in milliseconds) when automatic scheduling stops.</para>
        /// <para>This parameter corresponds to the end time of Effective Period in Scheduling &gt; Scheduling Time for Data Studio tasks in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4155787800000</para>
        /// </summary>
        [NameInMap("EndEffectDate")]
        [Validation(Required=false)]
        public long? EndEffectDate { get; set; }

        /// <summary>
        /// <para>The file description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Here is the file description</para>
        /// </summary>
        [NameInMap("FileDescription")]
        [Validation(Required=false)]
        public string FileDescription { get; set; }

        /// <summary>
        /// <para>The path to the folder where the file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/data_integration/Folder_1/Folder_2</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The file ID. You can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to obtain the file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The file name. You can modify the file name by setting a new value for FileName. For example, you can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to query the file ID in the target directory, and then call the <a href="https://help.aliyun.com/document_detail/173951.html">UpdateFile</a> operation with the file ID specified in the FileId parameter and a new value specified in the FileName parameter to modify the file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_user_info_d</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>This parameter corresponds to the Skip The Dry-Run Property Of The Ancestor Node option in Properties &gt; Dependencies &gt; Cross-cycle Dependency (Original Previous-cycle Dependency) when Instances of Current Node or Level-1 Child Node is selected for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreParentSkipRunningProperty")]
        [Validation(Required=false)]
        public bool? IgnoreParentSkipRunningProperty { get; set; }

        /// <summary>
        /// <para>The custom image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-uf6d7npxk1hhek8ng0cb</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The output names of the ancestor nodes on which the current node depends. Separate multiple output names with commas (,).</para>
        /// <para>This parameter corresponds to the Output Name of Ancestor Node setting in Properties &gt; Dependencies for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <remarks>
        /// <para>This parameter is required when you call the CreateDISyncTask or UpdateFile operation to create a batch synchronization node.</para>
        /// </remarks>
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
        /// <para>The outputs of the node.</para>
        /// <para>This parameter corresponds to the Output Name setting in Properties &gt; Dependencies for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project.ods_user_info_d</para>
        /// </summary>
        [NameInMap("OutputList")]
        [Validation(Required=false)]
        public string OutputList { get; set; }

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
        /// <para>The file owner ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18023848927592</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The scheduling parameters of the node.</para>
        /// <para>This parameter corresponds to the Scheduling Parameter setting in Properties for data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a y=b z=c</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. To obtain the ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the workspace management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_ALLOWD</description></item>
        /// <item><description>FAILURE_ALLOWED</description></item>
        /// <item><description>ALL_DENIED</description></item>
        /// <item><description>ALL_ALLOWED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The resource group for the task published from the file. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to query the available resource groups in the workspace.</para>
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
        /// <para>This parameter corresponds to the Start Method setting in Configuration &gt; Scheduling Policies in the right-side navigation pane on the editing page for EMR Spark Streaming and EMR Streaming SQL tasks in Data Studio in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
