// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateFileRequest : TeaModel {
        /// <summary>
        /// <para>The advanced settings of the node.</para>
        /// <para>This parameter corresponds to the Advanced Settings in the right-side navigation pane on the editing page for EMR Spark Streaming and EMR Streaming SQL data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>Currently, only EMR Spark Streaming and EMR Streaming SQL nodes support this parameter. The parameter value is in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;queue&quot;:&quot;default&quot;,&quot;SPARK_CONF&quot;:&quot;--conf spark.driver.memory=2g&quot;}</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public string AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether the scheduling configuration takes effect immediately after publishing.</para>
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
        /// <para>This parameter corresponds to the Code Parsing setting when you select Same Cycle under Scheduling Configuration &gt; Scheduling Dependency for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoParsing")]
        [Validation(Required=false)]
        public bool? AutoParsing { get; set; }

        /// <summary>
        /// <para>The interval between automatic reruns upon an error, in milliseconds. The maximum value is 1800000 milliseconds (30 minutes).</para>
        /// <para>This parameter corresponds to the Rerun Interval setting under Scheduling Configuration &gt; Time Properties &gt; Auto Rerun upon Error for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.
        /// The time unit for Rerun Interval in the console is minutes. Convert the time accordingly when calling this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("AutoRerunIntervalMillis")]
        [Validation(Required=false)]
        public int? AutoRerunIntervalMillis { get; set; }

        /// <summary>
        /// <para>The number of automatic reruns after an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRerunTimes")]
        [Validation(Required=false)]
        public int? AutoRerunTimes { get; set; }

        /// <summary>
        /// <para>The identifier of the data source used when the node corresponding to the file runs. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to obtain the list of available data sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_source</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The code content of the file. Files of different code types (fileType) have different code formats. In Operation Center, right-click a node of the corresponding type and select View Code to view the specific code format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT &quot;1&quot;;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The cron expression for timed scheduling. This parameter corresponds to the cron Expression setting under Scheduling Configuration &gt; Time Property for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure the Scheduling Epoch and Timed Scheduling time, DataWorks automatically generates the corresponding cron expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Timed scheduling at 05:30 every day: <c>00 30 05 * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Timed scheduling at the 15th minute of every hour: <c>00 15 * * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule every 10 minutes: <c>00 00/10 * * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule every 10 minutes from 08:00 to 17:00 every day: <c>00 00-59/10 8-23 * * * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Timed scheduling at 00:20 on the 1st of every month: <c>00 20 00 1 * ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Schedule every 3 months starting from 00:10 on January 1: <c>00 10 00 1 1-12/3 ?</c>.</para>
        /// </description></item>
        /// <item><description><para>Timed scheduling at 00:05 every Tuesday and Friday: <c>00 05 00 * * 2,5</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>The cron expression has the following limits due to the DataWorks scheduling system rules:</para>
        /// <list type="bullet">
        /// <item><description><para>The minimum scheduling interval is 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>The earliest scheduling time each day is 00:05.</para>
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
        /// <para>The type of the scheduling cycle. Valid values: NOT_DAY (minute or hour) and DAY (day, week, or month).</para>
        /// <para>This parameter corresponds to the Scheduling Cycle setting under Scheduling Configuration &gt; Time Properties for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes on which the current file depends when DependentType is set to USER_DEFINE. Separate multiple node IDs with commas (,).</para>
        /// <para>This parameter corresponds to the Settings when you select Other Nodes as the dependency after configuring Scheduling Configuration &gt; Scheduling Dependency to Previous Epoch for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. This is part of the parameter settings for scheduling dependencies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,10,15,20</para>
        /// </summary>
        [NameInMap("DependentNodeIdList")]
        [Validation(Required=false)]
        public string DependentNodeIdList { get; set; }

        /// <summary>
        /// <para>The mode in which the node depends on the previous cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: The dependency is set to the current node.</description></item>
        /// <item><description>CHILD: The dependency is set to first-level child nodes.</description></item>
        /// <item><description>USER_DEFINE: The dependency is set to other nodes.</description></item>
        /// <item><description>NONE: No dependency is selected. The node does not depend on the previous cycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINE</para>
        /// </summary>
        [NameInMap("DependentType")]
        [Validation(Required=false)]
        public string DependentType { get; set; }

        /// <summary>
        /// <para>The timestamp in milliseconds when automatic scheduling stops.</para>
        /// <para>This parameter corresponds to the end time in milliseconds under Scheduling Configuration &gt; Time Properties &gt; Effective Date for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>The path of the file.</para>
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
        /// <para>The name of the file. You can modify the file name by setting FileName to a new value.
        /// For example, call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to query the file ID in the target folder, and then call the <a href="https://help.aliyun.com/document_detail/173951.html">UpdateFile</a> operation to specify the file ID for the FileId parameter and configure the FileName parameter to rename the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_user_info_d</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the dry-run property of the upstream node under Scheduling Configuration &gt; Previous Cycle.</para>
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
        /// <para>The output names of the upstream files on which the current file depends. Separate multiple output names with commas (,).</para>
        /// <para>This parameter corresponds to the Parent Node Output Name setting when you select Same Cycle under Scheduling Configuration &gt; Scheduling Dependency for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a batch synchronization node by calling CreateDISyncTask and UpdateFile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The input context parameters of the node. The parameter value is in JSON format. For the fields included, refer to the InputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Input Parameters of Current Node setting under Scheduling Configuration &gt; Node Context for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ValueSource&quot;: &quot;project_001.first_node:bizdate_param&quot;,&quot;ParameterName&quot;: &quot;bizdate_input&quot;}]</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        /// <summary>
        /// <para>The output of the file.</para>
        /// <para>This parameter corresponds to the Output Name of Current Node setting when you select Same Cycle under Scheduling Configuration &gt; Scheduling Dependency for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project.ods_user_info_d</para>
        /// </summary>
        [NameInMap("OutputList")]
        [Validation(Required=false)]
        public string OutputList { get; set; }

        /// <summary>
        /// <para>The output context parameters of the node. The parameter value is in JSON format. For the fields included, refer to the OutputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Output Parameters of Current Node setting under Scheduling Configuration &gt; Node Context for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>This parameter corresponds to the Parameters setting under Scheduling Configuration for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a y=b z=c</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can logon to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Storage Management page to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Settings page to obtain the workspace name.</para>
        /// <para>You must specify either this parameter or ProjectId to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The rerun property. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_ALLOWED: The node can be rerun regardless of whether it runs successfully or fails.</description></item>
        /// <item><description>FAILURE_ALLOWED: The node can be rerun only after it fails.</description></item>
        /// <item><description>ALL_DENIED: The node cannot be rerun regardless of whether it runs successfully or fails.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Rerun Property setting under Scheduling Configuration &gt; Time Properties &gt; Rerun Property for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The schedule resource used when the file is published as a node and the node runs. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to obtain the list of available resource groups for the workspace.</para>
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
        /// <item><description>NORMAL: A normal scheduling node.</description></item>
        /// <item><description>MANUAL: A manual node that is not scheduled on a daily basis. This corresponds to nodes in a manual workflow.</description></item>
        /// <item><description>PAUSE: A paused node.</description></item>
        /// <item><description>SKIP: A dry-run node that is scheduled on a daily basis but is directly set to successful when scheduling starts.</description></item>
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
        /// <para>This parameter corresponds to the start time in milliseconds under Scheduling Configuration &gt; Time Properties &gt; Effective Date for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>936923400000</para>
        /// </summary>
        [NameInMap("StartEffectDate")]
        [Validation(Required=false)]
        public long? StartEffectDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to start the node immediately after publishing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Starts immediately after publishing.</description></item>
        /// <item><description>false: Does not start after publishing.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Start Mode setting under Configuration &gt; Time Properties in the right-side navigation pane on the editing page for EMR Spark Streaming and EMR Streaming SQL data development nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <item><description>true: Pauses scheduling.</description></item>
        /// <item><description>false: Does not pause scheduling.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the setting when Scheduling Type is set to Pause Scheduling under Scheduling Configuration &gt; Time Properties &gt; Scheduling Type for a data development node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

        /// <summary>
        /// <para>The timeout setting for the scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
