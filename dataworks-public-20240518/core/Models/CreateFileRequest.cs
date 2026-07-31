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
        /// <para>This parameter corresponds to the &quot;Advanced Settings&quot; in the right-side navigation bar on the editing page of EMR Spark Streaming and EMR Streaming SQL DataStudio nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>Specifies whether to enable automatic parsing for the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The file automatically parses code.</description></item>
        /// <item><description>false: The file does not automatically parse code.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the code parsing setting in the &quot;Schedule Configuration &gt; Scheduling Dependencies&quot; section of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoParsing")]
        [Validation(Required=false)]
        public bool? AutoParsing { get; set; }

        /// <summary>
        /// <para>The interval between automatic reruns upon failure, in milliseconds. The maximum value is 1800000 milliseconds (30 minutes).</para>
        /// <para>This parameter corresponds to the &quot;Rerun Interval&quot; setting in the &quot;Schedule Configuration &gt; Time Properties &gt; Auto Rerun upon Error&quot; section of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>The &quot;Rerun Interval&quot; in the console uses minutes as the unit. Convert the time accordingly when calling this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("AutoRerunIntervalMillis")]
        [Validation(Required=false)]
        public int? AutoRerunIntervalMillis { get; set; }

        /// <summary>
        /// <para>The number of automatic reruns after an error occurs. The maximum value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRerunTimes")]
        [Validation(Required=false)]
        public int? AutoRerunTimes { get; set; }

        /// <summary>
        /// <para>The data source that the node connects to when the file is published as a node and the node runs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/211432.html">UpdateDataSource</a> operation to obtain the list of available data sources in the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_source</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The code content of the file. Different code types (fileType) have different code formats.</para>
        /// <para>You can find the node of the corresponding type in Operation Center, right-click the node, and then click View Code to view the specific code format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create the directory if the specified directory (FileFolderPath) does not exist in the system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatically create the directory if it does not exist.</description></item>
        /// <item><description>false: The invocation fails if the directory does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateFolderIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateFolderIfNotExists { get; set; }

        /// <summary>
        /// <para>The cron expression for timed scheduling on an epoch basis. This parameter corresponds to the &quot;Schedule Configuration &gt; Time Property &gt; Cron Expression&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure the scheduling epoch and timed scheduling time, DataWorks automatically generates the corresponding cron expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Timed scheduling at 05:30 every day: <c>00 30 05 * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Timed scheduling at the 15th minute of every hour: <c>00 15 00-23/1 * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule every 10 minutes: <c>00 00/10 * * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule every 10 minutes from 08:00 to 17:00 every day: <c>00 00-59/10 8-17 * * * ?</c></para>
        /// </description></item>
        /// <item><description><para>Timed scheduling at 00:20 on the 1st of every month: <c>00 20 00 1 * ?</c></para>
        /// </description></item>
        /// <item><description><para>Schedule every 3 months starting from 00:10 on January 1: <c>00 10 00 1 1-12/3 ?</c></para>
        /// </description></item>
        /// <item><description><para>Timed scheduling at 00:05 every Tuesday and Friday: <c>00 05 00 * * 2,5</c></para>
        /// </description></item>
        /// </list>
        /// <para>Due to the rules of the DataWorks scheduling system, cron expressions have the following limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The minimum scheduling interval is 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>The earliest scheduling time each day is 00:05.</para>
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
        /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Time Properties &gt; Scheduling Cycle&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes that the current file depends on when DependentType is set to USER_DEFINE. Separate multiple node IDs with commas (,).</para>
        /// <para>This parameter corresponds to the node IDs specified when you select &quot;Other Nodes&quot; as the dependency after the parameter settings of &quot;Schedule Configuration &gt; Scheduling Dependencies&quot; are set to &quot;Cross-Epoch Dependency (Previous Epoch)&quot; for a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DependentNodeIdList")]
        [Validation(Required=false)]
        public string DependentNodeIdList { get; set; }

        /// <summary>
        /// <para>The type of cross-cycle dependency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: The dependency is the current node.</description></item>
        /// <item><description>CHILD: The dependency is the first-level child nodes.</description></item>
        /// <item><description>USER_DEFINE: The dependency is other specified nodes.</description></item>
        /// <item><description>NONE: No dependency is selected. The node does not depend on the previous cycle.   </description></item>
        /// <item><description>USER_DEFINE_AND_SELF: The dependency is a combination of the current node and other specified nodes across cycles.</description></item>
        /// <item><description>CHILD_AND_SELF: The dependency is a combination of the first-level child nodes and the current node across cycles.</description></item>
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
        /// <para>This parameter corresponds to the end time (in milliseconds) of the &quot;Schedule Configuration &gt; Time Properties &gt; Effective Date&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>The code type of the file.</para>
        /// <para>Different file types have different codes. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the code types of files.</para>
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
        /// <para>This parameter corresponds to the &quot;Upstream Node Output Name&quot; configured in the &quot;Schedule Configuration &gt; Scheduling Dependencies&quot; section of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The context input parameters of the node. The parameter value is in JSON format. For the fields included, see the InputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Node Context Parameters &gt; Input Parameters of This Node&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ValueSource&quot;: &quot;project_001.first_node:bizdate_param&quot;,&quot;ParameterName&quot;: &quot;bizdate_input&quot;}]</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        [NameInMap("OutputList")]
        [Validation(Required=false)]
        public string OutputList { get; set; }

        /// <summary>
        /// <para>The context output parameters of the node. The parameter value is in JSON format. For the fields included, see the OutputContextParameterList parameter structure in the response of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Node Context Parameters &gt; Output Parameters of This Node&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>The scheduling parameters. Separate multiple parameters with spaces.</para>
        /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Scheduling Parameters&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a=x b=y</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Settings page to obtain the workspace ID.</para>
        /// <para>You must specify either this parameter or ProjectIdentifier to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
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
        /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Time Properties &gt; Rerun Property&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>This field is deprecated. Do not use it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>375827434852437</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public long? ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The schedule resource used when the file is published as a node and the node runs. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Workspace Settings page, and click <b>Resource Groups</b> in the left-side navigation pane to obtain the ID of the resource group bound to the current workspace.</para>
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
        /// <item><description>NORMAL: A normal scheduling node.</description></item>
        /// <item><description>MANUAL: A manual node that is not scheduled on a daily basis. This corresponds to nodes in manual workflows.</description></item>
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
        /// <para>This parameter corresponds to the start time (in milliseconds) of the &quot;Schedule Configuration &gt; Time Properties &gt; Effective Date&quot; setting of a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671608450000</para>
        /// </summary>
        [NameInMap("StartEffectDate")]
        [Validation(Required=false)]
        public long? StartEffectDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to start the node immediately after it is published.</para>
        /// <para>This parameter corresponds to the &quot;Configuration &gt; Time Properties &gt; Startup Method&quot; setting in the right-side navigation bar on the editing page of EMR Spark Streaming and EMR Streaming SQL DataStudio nodes in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StartImmediately")]
        [Validation(Required=false)]
        public bool? StartImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to suspend scheduling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Suspend scheduling.</description></item>
        /// <item><description>false: Do not suspend scheduling.</description></item>
        /// </list>
        /// <para>This parameter corresponds to setting the &quot;Schedule Configuration &gt; Time Properties &gt; Scheduling Type&quot; to &quot;Suspend Scheduling&quot; for a DataStudio node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

        /// <summary>
        /// <para>The timeout value defined in the scheduling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
