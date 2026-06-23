// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the file.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileResponseBodyData Data { get; set; }
        public class GetFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Basic information about the file.</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataFile File { get; set; }
            public class GetFileResponseBodyDataFile : TeaModel {
                /// <summary>
                /// <para>Advanced configuration of the job.</para>
                /// <para>This parameter corresponds to &quot;Advanced Settings&quot; in the right-side navigation bar on the editing page of an EMR Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// <remarks>
                /// <para>Currently, EMR Shell jobs do not support advanced parameters.</para>
                /// </remarks>
                /// <para>For details about advanced parameters for different EMR job types, see <a href="https://help.aliyun.com/document_detail/473077.html">EMR Job Development</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;priority\&quot;:\&quot;1\&quot;,\&quot;ENABLE_SPARKSQL_JDBC\&quot;:false,\&quot;FLOW_SKIP_SQL_ANALYZE\&quot;:false,\&quot;queue\&quot;:\&quot;default\&quot;}</para>
                /// </summary>
                [NameInMap("AdvancedSettings")]
                [Validation(Required=false)]
                public string AdvancedSettings { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic parsing is enabled for the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The code in the file is automatically parsed.</para>
                /// </description></item>
                /// <item><description><para>false: The code in the file is not automatically parsed.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter corresponds to the &quot;Code Parsing&quot; option in the DataWorks console (https\://workbench.data.aliyun.com/console) when you select &quot;Same Cycle&quot; under Schedule Configuration &gt; Schedule Dependency for a Data Development job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                /// <summary>
                /// <para>The ID of the Business Process to which the file belongs. This field is deprecated. Use the BusinessId field instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The Business Process ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>The current commit status of the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: The latest code has not been submitted.</para>
                /// </description></item>
                /// <item><description><para>1: The latest code has been submitted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// <para>The name of the data source used when executing the job corresponding to the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para>The code of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>UNIX timestamp when the file was created, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud User ID of the file creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>424732****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>Version number of the latest submitted version of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The deletion status of the file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NORMAL: Not deleted.</para>
                /// </description></item>
                /// <item><description><para>RECYCLE_BIN: In the recycle bin.</para>
                /// </description></item>
                /// <item><description><para>DELETED: Deleted.</para>
                /// </description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>My first DataWorks file</para>
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
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000001</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>Name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The code type of the file. Different file types use different code. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks Edge Zone Collection</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource file needs to be uploaded to MaxCompute.
                /// Configure this parameter only when the file is a MaxCompute resource file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp of the most recent edit to the file, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud User ID of the user who last edited the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>424732****</para>
                /// </summary>
                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                /// <summary>
                /// <para>The ID of the scheduling task generated in the CDN mapping system after the file is submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300001</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>Alibaba Cloud User ID of the file owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7775674356****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>If the current file is an internal file of a composite edge zone file, this field identifies the ID of the corresponding composite edge zone file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The function module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NORMAL: Data Development.</para>
                /// </description></item>
                /// <item><description><para>MANUAL: One-time task.</para>
                /// </description></item>
                /// <item><description><para>MANUAL_BIZ: Manually triggered workflow.</para>
                /// </description></item>
                /// <item><description><para>SKIP: Dry-run scheduling in Data Development.</para>
                /// </description></item>
                /// <item><description><para>ADHOCQUERY: Ad-hoc query.</para>
                /// </description></item>
                /// <item><description><para>COMPONENT: Widget Management.</para>
                /// </description></item>
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
            /// <para>The schedule configuration of the file.</para>
            /// </summary>
            [NameInMap("NodeConfiguration")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataNodeConfiguration NodeConfiguration { get; set; }
            public class GetFileResponseBodyDataNodeConfiguration : TeaModel {
                /// <summary>
                /// <para>Whether to apply the schedule configuration immediately after publishing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ApplyScheduleImmediately")]
                [Validation(Required=false)]
                public string ApplyScheduleImmediately { get; set; }

                /// <summary>
                /// <para>The time interval between automatic reruns after an error, in milliseconds.</para>
                /// <para>This parameter corresponds to the &quot;Rerun Interval&quot; setting under &quot;Schedule Configuration &gt; Time Properties &gt; Auto Rerun on Error&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.<br>
                /// Note that the time unit for &quot;Rerun Interval&quot; in the console is minutes; convert the time accordingly when invoking the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("AutoRerunIntervalMillis")]
                [Validation(Required=false)]
                public int? AutoRerunIntervalMillis { get; set; }

                /// <summary>
                /// <para>The number of automatic reruns after an error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AutoRerunTimes")]
                [Validation(Required=false)]
                public int? AutoRerunTimes { get; set; }

                /// <summary>
                /// <para>The Cron Expression for timed scheduling of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00 05 00 * * ?</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <para>The type of recurrence, including NOT_DAY (minute, hour) and DAY (day, week, month).</para>
                /// <para>This parameter corresponds to &quot;Schedule Configuration &gt; Time Properties &gt; Recurrence&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAY</para>
                /// </summary>
                [NameInMap("CycleType")]
                [Validation(Required=false)]
                public string CycleType { get; set; }

                /// <summary>
                /// <para>When the DependentType parameter is set to USER_DEFINE, this parameter specifies the IDs of the nodes on which the current file depends. Separate multiple node IDs with commas (,).</para>
                /// <para>This parameter corresponds to the configuration when, in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, the &quot;Schedule Configuration &gt; Schedule Dependency&quot; of a Data Development job is set to &quot;Previous Cycle&quot; and the dependency option is set to &quot;Other Nodes&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5,10,15,20</para>
                /// </summary>
                [NameInMap("DependentNodeIdList")]
                [Validation(Required=false)]
                public string DependentNodeIdList { get; set; }

                /// <summary>
                /// <para>The method of depending on the previous cycle. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SELF: The dependency is the current node itself.</para>
                /// </description></item>
                /// <item><description><para>CHILD: The dependency is direct child nodes.</para>
                /// </description></item>
                /// <item><description><para>USER_DEFINE: The dependency is other specified nodes.</para>
                /// </description></item>
                /// <item><description><para>NONE: No dependency is selected, meaning the node does not depend on the previous cycle.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USER_DEFINE</para>
                /// </summary>
                [NameInMap("DependentType")]
                [Validation(Required=false)]
                public string DependentType { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp, in milliseconds, when automatic scheduling stops.</para>
                /// <para>This parameter corresponds to the millisecond UNIX timestamp of the end time configured in the &quot;Scan Configuration &gt; Time Properties &gt; Effective Date&quot; setting for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4155787800000</para>
                /// </summary>
                [NameInMap("EndEffectDate")]
                [Validation(Required=false)]
                public long? EndEffectDate { get; set; }

                /// <summary>
                /// <para>Schedule Configuration &gt; Previous Cycle &gt; Whether to ignore the upstream dry-run property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreParentSkipRunningProperty")]
                [Validation(Required=false)]
                public string IgnoreParentSkipRunningProperty { get; set; }

                /// <summary>
                /// <para>Custom image ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp1h4b5a8ogkbll2f3tr</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>Information about outputs from upstream files on which this file depends.</para>
                /// </summary>
                [NameInMap("InputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputList> InputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputList : TeaModel {
                    /// <summary>
                    /// <para>The output name of the upstream file on which this file depends.</para>
                    /// <para>This parameter corresponds to &quot;Parent Node Output Name&quot; when &quot;Same Cycle&quot; is selected under &quot;Schedule Configuration &gt; Schedule Dependency&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project.001_out</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public string Input { get; set; }

                    /// <summary>
                    /// <para>The method for configuring file dependencies. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>MANUAL: Manually configured.</para>
                    /// </description></item>
                    /// <item><description><para>AUTO: Automatically parsed.</para>
                    /// </description></item>
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
                /// <para>Return Result.</para>
                /// </summary>
                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputParameters> InputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputParameters : TeaModel {
                    /// <summary>
                    /// <para>The parameter name of the input parameter in the node context. You can reference this parameter in code by using the ${...} syntax.</para>
                    /// <para>This parameter corresponds to the &quot;Parameter Name&quot; field under &quot;Schedule Configuration &gt; Node Context &gt; Input Parameters of This Node&quot; in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <para>The value source of the input parameter in the node context.</para>
                    /// <para>This parameter corresponds to the &quot;Value Source&quot; field under &quot;Schedule Configuration &gt; Node Context &gt; Input Parameters of This Node&quot; in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project_001.parent_node:outputs</para>
                    /// </summary>
                    [NameInMap("ValueSource")]
                    [Validation(Required=false)]
                    public string ValueSource { get; set; }

                }

                /// <summary>
                /// <para>Output information of the file.</para>
                /// </summary>
                [NameInMap("OutputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputList> OutputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputList : TeaModel {
                    /// <summary>
                    /// <para>Output name of the file.</para>
                    /// <para>This parameter corresponds to the value in the &quot;Output Name&quot; column when &quot;Same Cycle&quot; is selected under &quot;Scan Configuration &gt; Schedule Dependency&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dw_project.002_out</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    /// <summary>
                    /// <para>Output value of the file.</para>
                    /// <para>This parameter corresponds to the value in the &quot;Output Table&quot; column when &quot;Same Cycle&quot; is selected under &quot;Scan Configuration &gt; Schedule Dependency&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ods_user_info_d</para>
                    /// </summary>
                    [NameInMap("RefTableName")]
                    [Validation(Required=false)]
                    public string RefTableName { get; set; }

                }

                /// <summary>
                /// <para>Return Result.</para>
                /// </summary>
                [NameInMap("OutputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputParameters> OutputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputParameters : TeaModel {
                    /// <summary>
                    /// <para>The description of the output parameter in the edge zone context.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>It\&quot;s a context output parameter.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The parameter name of the output parameter in the node context.</para>
                    /// <para>This parameter corresponds to the &quot;Parameter Name&quot; field under &quot;Schedule Configuration &gt; Node Context &gt; Output Parameters of This Node&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>output</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <para>The type of the expression for the edge zone context output parameter. Valid values are as follows:</para>
                    /// <list type="bullet">
                    /// <item><description><para>1: constant</para>
                    /// </description></item>
                    /// <item><description><para>2: variable</para>
                    /// </description></item>
                    /// <item><description><para>3: pass-through variable from a parameter node</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter corresponds to the &quot;Type&quot; field in the &quot;Scan Configuration &gt; Edge Zone Context &gt; Output Parameters of This Node&quot; section for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The expression of the output parameter in the edge zone context.</para>
                    /// <para>This parameter corresponds to the &quot;Value&quot; field in the &quot;Scan Configuration &gt; Edge Zone Context &gt; Output Parameters of This Node&quot; section for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${bizdate}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Schedule parameter.</para>
                /// <para>This parameter corresponds to the &quot;Scan Configuration &gt; Parameters&quot; setting for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. You can refer to the <a href="https://help.aliyun.com/document_detail/137548.html">Schedule Parameters</a> documentation for configuration details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a=x b=y</para>
                /// </summary>
                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

                /// <summary>
                /// <para>Rerun property. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ALL_ALLOWED: The job can be rerun regardless of whether it previously Succeeded or failed.</para>
                /// </description></item>
                /// <item><description><para>FAILURE_ALLOWED: The job cannot be rerun if it previously Succeeded, but can be rerun if it previously failed.</para>
                /// </description></item>
                /// <item><description><para>ALL_DENIED: The job cannot be rerun regardless of whether it previously Succeeded or failed.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter corresponds to the &quot;Scan Configuration &gt; Time Properties &gt; Rerun Property&quot; setting for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL_ALLOWED</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <para>The resource group used when the file is published as a Job and executed. You can call <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> to obtain the list of available resource groups in the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>375827434852437</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public long? ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The schedule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NORMAL: Normal scheduling task.</para>
                /// </description></item>
                /// <item><description><para>MANUAL: One-time task, which is not included in regular scheduling and corresponds to a node in a manually triggered workflow.</para>
                /// </description></item>
                /// <item><description><para>PAUSE: Paused task.</para>
                /// </description></item>
                /// <item><description><para>SKIP: Dry-run task, which is included in regular scheduling but is immediately marked as Succeeded when scheduled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp (in milliseconds) indicating when automatic scheduling starts.</para>
                /// <para>This parameter corresponds to the start time (as a UNIX timestamp in milliseconds) configured under &quot;Schedule Configuration &gt; Time Properties &gt; Effective Date&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>936923400000</para>
                /// </summary>
                [NameInMap("StartEffectDate")]
                [Validation(Required=false)]
                public long? StartEffectDate { get; set; }

                /// <summary>
                /// <para>Indicates whether to start immediately after publishing.</para>
                /// <para>This parameter corresponds to the &quot;Start Method&quot; setting under &quot;Configuration &gt; Time Properties&quot; in the right-side navigation bar on the editing page for EMR Spark Streaming and EMR Streaming SQL Data Development jobs in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StartImmediately")]
                [Validation(Required=false)]
                public bool? StartImmediately { get; set; }

                /// <summary>
                /// <para>Indicates whether to skip execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Skip execution.</para>
                /// </description></item>
                /// <item><description><para>false: Do not skip execution.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter corresponds to the setting &quot;Schedule Type&quot; under &quot;Schedule Configuration &gt; Time Properties&quot; for a Data Development job in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, when it is set to &quot;skip execution&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <para>Timeout definition for scheduling configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

            }

            /// <summary>
            /// <para>Resource download link.</para>
            /// </summary>
            [NameInMap("ResourceDownloadLink")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataResourceDownloadLink ResourceDownloadLink { get; set; }
            public class GetFileResponseBodyDataResourceDownloadLink : TeaModel {
                /// <summary>
                /// <para>Link for downloading the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xx">http://xx</a></para>
                /// </summary>
                [NameInMap("downloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

            }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request ID. Used for troubleshooting when a fault occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the invocation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The invocation succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: Failed to invoke.</para>
        /// </description></item>
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
