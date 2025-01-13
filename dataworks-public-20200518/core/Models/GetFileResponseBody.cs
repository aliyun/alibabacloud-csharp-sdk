// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the file.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileResponseBodyData Data { get; set; }
        public class GetFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic information about the file.</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataFile File { get; set; }
            public class GetFileResponseBodyDataFile : TeaModel {
                /// <summary>
                /// <para>The advanced configurations of the node.</para>
                /// <para>This parameter is valid for an EMR node. This parameter corresponds to the Advanced Settings tab in the right-side navigation pane on the configuration tab of the node in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// <remarks>
                /// <para> You cannot configure advanced parameters for EMR Shell nodes.</para>
                /// </remarks>
                /// <para>For information about the advanced parameters of each type of EMR node, see <a href="https://help.aliyun.com/document_detail/473077.html">Develop EMR tasks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;queue&quot;:&quot;default&quot;,&quot;SPARK_CONF&quot;:&quot;--conf spark.driver.memory=2g&quot;}</para>
                /// </summary>
                [NameInMap("AdvancedSettings")]
                [Validation(Required=false)]
                public string AdvancedSettings { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic parsing feature is enabled for the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The automatic parsing feature is enabled for the file.</description></item>
                /// <item><description>false: The automatic parsing feature is not enabled for the file.</description></item>
                /// </list>
                /// <para>This parameter corresponds to the Analyze Code parameter that is displayed after Same Cycle is selected in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the file belongs. This parameter is deprecated and replaced by the BusinessId parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>Indicates whether the latest code in the file is committed. Valid values: 0 and 1. The value 0 indicates that the latest code in the file is not committed. The value 1 indicates that the latest code in the file is committed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// <para>The ID of the compute engine instance that is used to run the node that corresponds to the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para>The code in the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The time when the file was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used to create the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>424732****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The latest version number of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The status of the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The file is not deleted.</description></item>
                /// <item><description>RECYCLE_BIN: The file is stored in the recycle bin.</description></item>
                /// <item><description>DELETED: The file is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RECYCLE</para>
                /// </summary>
                [NameInMap("DeletedStatus")]
                [Validation(Required=false)]
                public string DeletedStatus { get; set; }

                /// <summary>
                /// <para>The description of the file.</para>
                /// </summary>
                [NameInMap("FileDescription")]
                [Validation(Required=false)]
                public string FileDescription { get; set; }

                /// <summary>
                /// <para>The ID of the folder to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2735c2****</para>
                /// </summary>
                [NameInMap("FileFolderId")]
                [Validation(Required=false)]
                public string FileFolderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000001</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The type of the code for the file. The code for files varies based on the file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <para>Indicates whether the file needs to be uploaded to MaxCompute.</para>
                /// <para>This parameter is returned only if the file is a MaxCompute resource file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                /// <summary>
                /// <para>The time when the file was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used to last modify the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62465892****</para>
                /// </summary>
                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                /// <summary>
                /// <para>The ID of the auto triggered node that is generated in the scheduling system after the file is committed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300001</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the file owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7775674356****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the node group file to which the current file belongs. This parameter is returned only if the current file is an inner file of the node group file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The file is used for DataStudio.</description></item>
                /// <item><description>MANUAL: The file is used for a manually triggered node.</description></item>
                /// <item><description>MANUAL_BIZ: The file is used for a manually triggered workflow.</description></item>
                /// <item><description>SKIP: The file is used for a dry-run DataStudio node.</description></item>
                /// <item><description>ADHOCQUERY: The file is used for an ad hoc query.</description></item>
                /// <item><description>COMPONENT: The file is used for a snippet.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <para>The scheduling configurations of the file.</para>
            /// </summary>
            [NameInMap("NodeConfiguration")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataNodeConfiguration NodeConfiguration { get; set; }
            public class GetFileResponseBodyDataNodeConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether scheduling configurations immediately take effect after the deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ApplyScheduleImmediately")]
                [Validation(Required=false)]
                public string ApplyScheduleImmediately { get; set; }

                /// <summary>
                /// <para>The interval between automatic reruns after an error occurs. Unit: milliseconds.</para>
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
                /// <para>The number of automatic reruns that are allowed after an error occurs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AutoRerunTimes")]
                [Validation(Required=false)]
                public int? AutoRerunTimes { get; set; }

                /// <summary>
                /// <para>The CRON expression that represents the periodic scheduling policy of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00 05 00 * * ?</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <para>The type of the scheduling cycle. Valid values: NOT_DAY and DAY. The value NOT_DAY indicates that the node is scheduled to run by minute or hour. The value DAY indicates that the node is scheduled to run by day, week, or month.</para>
                /// <para>This parameter corresponds to the Scheduling Cycle parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAY</para>
                /// </summary>
                [NameInMap("CycleType")]
                [Validation(Required=false)]
                public string CycleType { get; set; }

                /// <summary>
                /// <para>The ID of the node on which the node corresponding to the file depends when the DependentType parameter is set to USER_DEFINE. Multiple IDs are separated by commas (,).</para>
                /// <para>The value of this parameter is equivalent to the ID of the node that you specified after you select Previous Cycle and set Depend On to Other Nodes in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5,10,15,20</para>
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
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USER_DEFINE</para>
                /// </summary>
                [NameInMap("DependentType")]
                [Validation(Required=false)]
                public string DependentType { get; set; }

                /// <summary>
                /// <para>The end time of automatic scheduling. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// <para>This parameter corresponds to the Validity Period parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4155787800000</para>
                /// </summary>
                [NameInMap("EndEffectDate")]
                [Validation(Required=false)]
                public long? EndEffectDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreParentSkipRunningProperty")]
                [Validation(Required=false)]
                public string IgnoreParentSkipRunningProperty { get; set; }

                /// <summary>
                /// <para>The output names of the parent files on which the current file depends.</para>
                /// </summary>
                [NameInMap("InputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputList> InputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputList : TeaModel {
                    /// <summary>
                    /// <para>The output name of the parent file on which the current file depends.</para>
                    /// <para>This parameter corresponds to the Output Name of Ancestor Node parameter under Parent Nodes after Same Cycle is selected in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project.001_out</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public string Input { get; set; }

                    /// <summary>
                    /// <para>The mode of the configuration file dependency. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>MANUAL: Scheduling dependencies are manually configured.</description></item>
                    /// <item><description>AUTO: Scheduling dependencies are automatically parsed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MANUAL</para>
                    /// </summary>
                    [NameInMap("ParseType")]
                    [Validation(Required=false)]
                    public string ParseType { get; set; }

                }

                /// <summary>
                /// <para>Input parameters of the node.</para>
                /// <para>This parameter corresponds to the Input Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// </summary>
                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputParameters> InputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputParameters : TeaModel {
                    /// <summary>
                    /// <para>The name of the input parameter of the node. In the code, you can use the ${...} method to reference the input parameter of the node.</para>
                    /// <para>This parameter corresponds to the Parameter Name parameter in the Input Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <para>The value source of the input parameter of the node.</para>
                    /// <para>This parameter corresponds to the Value Source parameter in the Input Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project_001.parent_node:outputs</para>
                    /// </summary>
                    [NameInMap("ValueSource")]
                    [Validation(Required=false)]
                    public string ValueSource { get; set; }

                }

                /// <summary>
                /// <para>The output names of the current file.</para>
                /// <para>This parameter corresponds to the Output Name parameter under Output after Same Cycle is selected in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// </summary>
                [NameInMap("OutputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputList> OutputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputList : TeaModel {
                    /// <summary>
                    /// <para>The output name of the current file.</para>
                    /// <para>This parameter corresponds to the Output Name parameter under Output after Same Cycle is selected in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dw_project.002_out</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    /// <summary>
                    /// <para>The output table name of the current file.</para>
                    /// <para>This parameter corresponds to the Output Table Name parameter under Output after Same Cycle is selected in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ods_user_info_d</para>
                    /// </summary>
                    [NameInMap("RefTableName")]
                    [Validation(Required=false)]
                    public string RefTableName { get; set; }

                }

                /// <summary>
                /// <para>Output parameters of the node.</para>
                /// <para>This parameter corresponds to the Output Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// </summary>
                [NameInMap("OutputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputParameters> OutputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputParameters : TeaModel {
                    /// <summary>
                    /// <para>The description of the output parameter of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>It\&quot;s a context output parameter.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the output parameter of the node.</para>
                    /// <para>This parameter corresponds to the Parameter Name parameter in the Output Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>output</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <para>The type of the output parameter of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: indicates a constant.</description></item>
                    /// <item><description>2: indicates a variable.</description></item>
                    /// <item><description>3: indicates a pass-through variable.</description></item>
                    /// </list>
                    /// <para>This parameter corresponds to the Type parameter in the Output Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the output parameter of the node.</para>
                    /// <para>This parameter corresponds to the Value parameter in the Output Parameters table in the Input and Output Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${bizdate}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The scheduling parameters of the node.</para>
                /// <para>This parameter corresponds to the Parameters section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information about the configurations of the scheduling parameters, see <a href="https://help.aliyun.com/document_detail/137548.html">Configure scheduling parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a=x b=y</para>
                /// </summary>
                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

                /// <summary>
                /// <para>Indicates whether the node that corresponds to the file can be rerun. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALL_ALLOWED: The node can be rerun regardless of whether it is successfully run or fails to run.</description></item>
                /// <item><description>FAILURE_ALLOWED: The node can be rerun only after it fails to run.</description></item>
                /// <item><description>ALL_DENIED: The node cannot be rerun regardless of whether it is successfully run or fails to run.</description></item>
                /// </list>
                /// <para>This parameter corresponds to the Rerun parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL_ALLOWED</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The ID of the resource group that is used to run the node. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to query the available resource groups in the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>375827434852437</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public long? ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The scheduling type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The node is an auto triggered node.</description></item>
                /// <item><description>MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered. They correspond to the nodes in the Manually Triggered Workflows pane.</description></item>
                /// <item><description>PAUSE: The node is a paused node.</description></item>
                /// <item><description>SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled but the system sets the status of the nodes to successful when it starts to run them.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The start time of automatic scheduling. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// <para>This parameter corresponds to the Validity Period parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>936923400000</para>
                /// </summary>
                [NameInMap("StartEffectDate")]
                [Validation(Required=false)]
                public long? StartEffectDate { get; set; }

                /// <summary>
                /// <para>Indicates whether a node is immediately run after the node is deployed to the production environment.</para>
                /// <para>This parameter is valid only for an EMR Spark Streaming node or an EMR Streaming SQL node. This parameter corresponds to the Start Method parameter in the Schedule section of the Configure tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StartImmediately")]
                [Validation(Required=false)]
                public bool? StartImmediately { get; set; }

                /// <summary>
                /// <para>Indicates whether the scheduling for the node is suspended Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The scheduling for the node is suspended.</description></item>
                /// <item><description>false: The scheduling for the node is not suspended.</description></item>
                /// </list>
                /// <para>This parameter corresponds to the Recurrence parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

            }

            [NameInMap("ResourceDownloadLink")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataResourceDownloadLink ResourceDownloadLink { get; set; }
            public class GetFileResponseBodyDataResourceDownloadLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xx">http://xx</a></para>
                /// </summary>
                [NameInMap("downloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
