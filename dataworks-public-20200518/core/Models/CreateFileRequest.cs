// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// <para>The advanced configurations of the node.</para>
        /// <para>This parameter is valid only for an EMR Spark Streaming node or an EMR Streaming SQL node. This parameter corresponds to the Advanced Settings tab of the node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>The value of this parameter must be in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;queue&quot;:&quot;default&quot;,&quot;SPARK_CONF&quot;:&quot;--conf spark.driver.memory=2g&quot;}</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public string AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether scheduling configurations immediately take effect after the node is deployed.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Analyze Code parameter that is displayed after Same Cycle is selected in the Dependencies section of the Properties tab on the DataStudio page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoParsing")]
        [Validation(Required=false)]
        public bool? AutoParsing { get; set; }

        /// <summary>
        /// <para>The interval between automatic reruns after an error occurs. Unit: milliseconds. Maximum value: 1800000 (30 minutes).</para>
        /// <para>This parameter corresponds to the Rerun Interval parameter that is displayed after the Auto Rerun upon Error check box is selected in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>The interval that you specify in the DataWorks console is measured in minutes. Pay attention to the conversion between the units of time when you call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("AutoRerunIntervalMillis")]
        [Validation(Required=false)]
        public int? AutoRerunIntervalMillis { get; set; }

        /// <summary>
        /// <para>The number of automatic reruns that are allowed after an error occurs. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRerunTimes")]
        [Validation(Required=false)]
        public int? AutoRerunTimes { get; set; }

        /// <summary>
        /// <para>The name of the data source for which the node is run.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/211432.html">UpdateDataSource</a> operation to query the available data sources in the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps_first</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The code for the file. The code format varies based on the file type. To view the code format for a specific file type, go to Operation Center, right-click a node of the file type, and then select View Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHOW TABLES;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create the directory that is specified by the FileFolderPath parameter if the directory does not exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system automatically creates the directory if the directory does not exist.</description></item>
        /// <item><description>false: The system does not automatically create the directory if the directory does not exist. In this case, the call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateFolderIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateFolderIfNotExists { get; set; }

        /// <summary>
        /// <para>The CRON expression that represents the periodic scheduling policy of the node. This parameter corresponds to the Cron Expression parameter in the Schedule section of the Properties tab on the DataStudio page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. After you configure the Scheduling Cycle and Scheduled time parameters in the DataWorks console, DataWorks generates the value of the Cron Expression parameter.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>CRON expression for a node that is scheduled to run at 05:30 every day: <c>00 30 05 * * ?</c></description></item>
        /// <item><description>CRON expression for a node that is scheduled to run at the fifteenth minute of each hour: <c>00 15 00-23/1 * * ?</c></description></item>
        /// <item><description>CRON expression for a node that is scheduled to run every 10 minutes: <c>00 00/10 * * * ?</c></description></item>
        /// <item><description>CRON expression for a node that is scheduled to run every 10 minutes from 08:00 to 17:00 every day: <c>00 00-59/10 8-17 * * * ?</c></description></item>
        /// <item><description>CRON expression for a node that is scheduled to run at 00:20 on the first day of each month: <c>00 20 00 1 * ?</c></description></item>
        /// <item><description>CRON expression for a node that is scheduled to run every three months from 00:10 on January 1: <c>00 10 00 1 1-12/3 ?</c></description></item>
        /// <item><description>CRON expression for a node that is scheduled to run at 00:05 every Tuesday and Friday: <c>00 05 00 * * 2,5</c></description></item>
        /// </list>
        /// <para>The scheduling system of DataWorks imposes the following limits on CRON expressions:</para>
        /// <list type="bullet">
        /// <item><description>The minimum interval specified in a CRON expression to schedule a node is 5 minutes.</description></item>
        /// <item><description>The earliest time specified in a CRON expression to schedule a node every day is 00:05.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>00 05 00 * * ?</para>
        /// </summary>
        [NameInMap("CronExpress")]
        [Validation(Required=false)]
        public string CronExpress { get; set; }

        /// <summary>
        /// <para>The type of the scheduling cycle of the node that corresponds to the file. Valid values: NOT_DAY and DAY. The value NOT_DAY indicates that the node is scheduled to run by minute or hour. The value DAY indicates that the node is scheduled to run by day, week, or month.</para>
        /// <para>This parameter corresponds to the Scheduling Cycle parameter in the Schedule section of the Properties tab on the DataStudio page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes that generate instances in the previous cycle on which the current node depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DependentNodeIdList")]
        [Validation(Required=false)]
        public string DependentNodeIdList { get; set; }

        /// <summary>
        /// <para>The type of the cross-cycle scheduling dependency of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: The instance generated for the node in the current cycle depends on the instance generated for the node in the previous cycle.</description></item>
        /// <item><description>CHILD: The instance generated for the node in the current cycle depends on the instances generated for the descendant nodes at the nearest level of the node in the previous cycle.</description></item>
        /// <item><description>USER_DEFINE: The instance generated for the node in the current cycle depends on the instances generated for one or more specified nodes in the previous cycle.</description></item>
        /// <item><description>NONE: No cross-cycle scheduling dependency type is selected for the node.</description></item>
        /// <item><description>USER_DEFINE_AND_SELF: The instance generated for the node in the current cycle depends on the instance generated for the node in the previous cycle and the instances generated for one or more specified nodes in the previous cycle.</description></item>
        /// <item><description>CHILD_AND_SELF: The instance generated for the node in the current cycle depends on the instances generated for the descendant nodes at the nearest level of the node in the previous cycle and the instance generated for the node in the previous cycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("DependentType")]
        [Validation(Required=false)]
        public string DependentType { get; set; }

        /// <summary>
        /// <para>The end time of automatic scheduling. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter corresponds to the Validity Period parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
        /// <para>Here is the file description</para>
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
        /// <para>The type of the code for the file. The code for files varies based on the file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the type of the code for the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// <para>Whether to use the last cycle empty run attribute. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>true: The empty run attribute of the previous cycle is used.</description></item>
        /// <item><description>false: The empty run attribute of the previous cycle is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreParentSkipRunningProperty")]
        [Validation(Required=false)]
        public bool? IgnoreParentSkipRunningProperty { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The output name of the parent file on which the current file depends. If you specify multiple output names, separate them with commas (,).</para>
        /// <para>This parameter corresponds to the Output Name parameter under Parent Nodes in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_root,project.file1,project.001_out</para>
        /// </summary>
        [NameInMap("InputList")]
        [Validation(Required=false)]
        public string InputList { get; set; }

        /// <summary>
        /// <para>The input parameters of the node. The value of this parameter must be in the JSON format. For more information about the input parameters, see the InputContextParameterList parameter in the Response parameters section of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Input Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ValueSource&quot;: &quot;project_001.first_node:bizdate_param&quot;,&quot;ParameterName&quot;: &quot;bizdate_input&quot;}]</para>
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParameters { get; set; }

        /// <summary>
        /// <para>The output parameters of the node. The value of this parameter must be in the JSON format. For more information about the output parameters, see the OutputContextParameterList parameter in the Response parameters section of the <a href="https://help.aliyun.com/document_detail/173954.html">GetFile</a> operation.</para>
        /// <para>This parameter corresponds to the Output Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Type&quot;: 1,&quot;Value&quot;: &quot;${bizdate}&quot;,&quot;ParameterName&quot;: &quot;bizdate_param&quot;}]</para>
        /// </summary>
        [NameInMap("OutputParameters")]
        [Validation(Required=false)]
        public string OutputParameters { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the file owner. If this parameter is not configured, the ID of the Alibaba Cloud account of the user who calls the operation is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The scheduling parameters of the node. Separate multiple parameters with spaces.</para>
        /// <para>This parameter corresponds to the Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information about the configurations of the scheduling parameters, see <a href="https://help.aliyun.com/document_detail/137548.html">Configure scheduling parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a=x b=y</para>
        /// </summary>
        [NameInMap("ParaValue")]
        [Validation(Required=false)]
        public string ParaValue { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// <para>You must configure this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace name.</para>
        /// <para>You must configure this parameter or the ProjectId parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>Specifies whether the node that corresponds to the file can be rerun. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_ALLOWED: The node can be rerun regardless of whether it is successfully run or fails to run.</description></item>
        /// <item><description>FAILURE_ALLOWED: The node can be rerun only after it fails to run.</description></item>
        /// <item><description>ALL_DENIED: The node cannot be rerun regardless of whether it is successfully run or fails to run.</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Rerun parameter in the Schedule section of the Properties tab on the DataStudio page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ALLOWED</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Do not use this parameter.</para>
        /// <para>The identifier of the resource group that is used to run the node. This parameter corresponds to the Resource Group parameter in the Resource Group section of the Properties tab in the DataWorks console. You must configure one of the ResourceGroupId and ResourceGroupIdentifier parameters to determine the resource group that is used to run the node.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to query the available resource groups in the workspace. When you call the operation, set the ResourceGroupType parameter to 1. The response parameter Id indicates the ID of an available resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>375827434852437</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public long? ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The identifier of the resource group that is used to run the node. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to query the available resource groups in the workspace. The <b>Identifier</b> parameter in the response of the operation indicates the identifier of an available resource group.</para>
        /// <remarks>
        /// <para> You must make sure that the available resource groups in the response of the ListResourceGroups operation are associated with the workspace for which you want to create a file by calling the CreateFile operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>group_375827434852437</para>
        /// </summary>
        [NameInMap("ResourceGroupIdentifier")]
        [Validation(Required=false)]
        public string ResourceGroupIdentifier { get; set; }

        /// <summary>
        /// <para>The scheduling type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: The node is an auto triggered node.</description></item>
        /// <item><description>MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered. They correspond to the nodes in the Manually Triggered Workflows pane.</description></item>
        /// <item><description>PAUSE: The node is a paused node.</description></item>
        /// <item><description>SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled, but the system sets the status of the nodes to successful when it starts to run them</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

        /// <summary>
        /// <para>The start time of automatic scheduling. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>Configuring this parameter is equivalent to specifying a start time for the Validity Period parameter in the Schedule section of the Properties tab on the DataStudio page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671608450000</para>
        /// </summary>
        [NameInMap("StartEffectDate")]
        [Validation(Required=false)]
        public long? StartEffectDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately run a node after the node is deployed.</para>
        /// <para>This parameter is valid only for an EMR Spark Streaming node or an EMR Streaming SQL node. This parameter corresponds to the Start Method parameter in the Schedule section of the Configure tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StartImmediately")]
        [Validation(Required=false)]
        public bool? StartImmediately { get; set; }

        /// <summary>
        /// <para>Specifies whether to suspend the scheduling of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter corresponds to the Recurrence parameter in the Schedule section of the Properties tab on the DataStudio page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

        /// <summary>
        /// <para>The timeout period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
