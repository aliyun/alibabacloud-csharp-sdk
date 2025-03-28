// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDISyncTaskResponseBodyData Data { get; set; }
        public class GetDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert rules that are associated with the real-time synchronization task. The value of this parameter is an array.</para>
            /// </summary>
            [NameInMap("AlarmList")]
            [Validation(Required=false)]
            public List<GetDISyncTaskResponseBodyDataAlarmList> AlarmList { get; set; }
            public class GetDISyncTaskResponseBodyDataAlarmList : TeaModel {
                /// <summary>
                /// <para>The alert notification settings. The value of this parameter is an array.</para>
                /// </summary>
                [NameInMap("AlarmRuleList")]
                [Validation(Required=false)]
                public List<GetDISyncTaskResponseBodyDataAlarmListAlarmRuleList> AlarmRuleList { get; set; }
                public class GetDISyncTaskResponseBodyDataAlarmListAlarmRuleList : TeaModel {
                    /// <summary>
                    /// <para>The calculation method of a metric. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>avg</description></item>
                    /// <item><description>max</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>avg</para>
                    /// </summary>
                    [NameInMap("Aggregator")]
                    [Validation(Required=false)]
                    public string Aggregator { get; set; }

                    /// <summary>
                    /// <para>The comparison operator, which indicates the method used to compare a metric with the alert rule.</para>
                    /// <list type="bullet">
                    /// <item><description>\&quot;=\&quot;</description></item>
                    /// <item><description>\&quot;&lt;\&quot;</description></item>
                    /// <item><description>\&quot;&gt;\&quot;</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Comparator")]
                    [Validation(Required=false)]
                    public string Comparator { get; set; }

                    /// <summary>
                    /// <para>The duration that a condition is met before an alert is triggered. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>WARNING</description></item>
                    /// <item><description>CRITICAL</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WARNING</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The threshold for the comparison between a metric and the alert rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public long? Threshold { get; set; }

                }

                /// <summary>
                /// <para>The description of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45242</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The alert type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>taskStatus</description></item>
                /// <item><description>bizDelay</description></item>
                /// <item><description>taskFailoverCount</description></item>
                /// <item><description>ddlUnsupport</description></item>
                /// <item><description>ddlReport</description></item>
                /// <item><description>totalDirtyRecordWriteInLines</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>taskStatus</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The settings for alert notification rules. The value of this parameter is an array.</para>
                /// </summary>
                [NameInMap("NotifyRule")]
                [Validation(Required=false)]
                public GetDISyncTaskResponseBodyDataAlarmListNotifyRule NotifyRule { get; set; }
                public class GetDISyncTaskResponseBodyDataAlarmListNotifyRule : TeaModel {
                    /// <summary>
                    /// <para>The settings for Critical-level alert notifications.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public List<string> Critical { get; set; }

                    /// <summary>
                    /// <para>The alert interval. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public long? Interval { get; set; }

                    /// <summary>
                    /// <para>The settings for Warning-level alert notifications.</para>
                    /// </summary>
                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public List<string> Warning { get; set; }

                }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Delay alert rule name 1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If the TaskType parameter is set to DI_REALTIME, the details of the real-time synchronization task are returned.</description></item>
            /// <item><description>If the TaskType parameter is set to DI_SOLUTION, the value null is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;extend&quot;:{&quot;mode&quot;:&quot;wizard&quot;,&quot;resourceGroup&quot;:&quot;S_res_group_287114642182658_1560324290517&quot;},&quot;nodeDef&quot;:{},&quot;order&quot;:{&quot;hops&quot;:[{&quot;from&quot;:&quot;datahub_8htXSsfiS2vtZCVG&quot;,&quot;to&quot;:&quot;datahub_CRHBAyGfhSaLmv2f&quot;}]},&quot;setting&quot;:{&quot;errorLimit&quot;:{},&quot;jvmOption&quot;:&quot;&quot;},&quot;steps&quot;:[{&quot;stepType&quot;:&quot;datahub&quot;,&quot;category&quot;:&quot;writer&quot;,&quot;displayName&quot;:&quot;DataHub1&quot;,&quot;parameter&quot;:{&quot;batchSize&quot;:1000,&quot;datasource&quot;:&quot;datahub_cloud_dev_test&quot;,&quot;topic&quot;:&quot;dwd_tfc_opt_speed_rid_amap_rt&quot;},&quot;name&quot;:&quot;datahub_CRHBAyGfhSaLmv2f&quot;,&quot;gui&quot;:{&quot;x&quot;:262,&quot;y&quot;:325}},{&quot;stepType&quot;:&quot;datahub&quot;,&quot;displayName&quot;:&quot;DataHub2&quot;,&quot;parameter&quot;:{&quot;datasource&quot;:&quot;datahub_uric_test&quot;,&quot;topic&quot;:&quot;dwd_tfc_opt_speed_rid_amap_rt_330000&quot;,&quot;batchSize&quot;:1000},&quot;name&quot;:&quot;datahub_8htXSsfiS2vtZCVG&quot;,&quot;gui&quot;:{&quot;x&quot;:268,&quot;y&quot;:160.5},&quot;category&quot;:&quot;writer&quot;}]}</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The cause of the failure to obtain the details of the real-time synchronization task or data synchronization solution.</para>
            /// <para>If the details of the real-time synchronization task or data synchronization solution are obtained, the value null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileId:[100] is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>If the TaskType parameter is set to DI_REALTIME, the value null is returned.</description></item>
            /// <item><description>If the TaskType parameter is set to DI_SOLUTION, the details of the data synchronization solution are returned.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SolutionDetail")]
            [Validation(Required=false)]
            public GetDISyncTaskResponseBodyDataSolutionDetail SolutionDetail { get; set; }
            public class GetDISyncTaskResponseBodyDataSolutionDetail : TeaModel {
                /// <summary>
                /// <para>The creator of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataworks_di</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The ID of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>holo_20211206161025</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The configuration details of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;holoDatasource&quot;:&quot;holo&quot;,&quot;offlineSyncConfig&quot;:{&quot;nodeNameRule&quot;:&quot;oneclick_holo_di_${db_table_name_src}<em>to</em>${db_table_name_dest}&quot;,&quot;resourceGroup&quot;:&quot;group_219193793999490&quot;},&quot;processRuleId&quot;:1007,&quot;readerConcurrent&quot;:10,&quot;realtimeSyncConfig&quot;:{&quot;content&quot;:{&quot;order&quot;:{&quot;hops&quot;:[{&quot;from&quot;:&quot;reader&quot;,&quot;to&quot;:&quot;writer&quot;}]},&quot;setting&quot;:{&quot;speed&quot;:{&quot;readerConcurrent&quot;:10}},&quot;steps&quot;:[{&quot;stepType&quot;:&quot;mysql&quot;,&quot;name&quot;:&quot;reader&quot;,&quot;category&quot;:&quot;reader&quot;,&quot;parameter&quot;:{&quot;connection&quot;:[{&quot;datasource&quot;:&quot;mm&quot;,&quot;datasourceType&quot;:&quot;mysql&quot;,&quot;table&quot;:[]}]}},{&quot;stepType&quot;:&quot;holo&quot;,&quot;name&quot;:&quot;writer&quot;,&quot;category&quot;:&quot;writer&quot;,&quot;parameter&quot;:{&quot;datasource&quot;:&quot;holo&quot;,&quot;writeMode&quot;:&quot;replay&quot;,&quot;datasourceSchema&quot;:&quot;public&quot;,&quot;tableMappingRule&quot;:{&quot;datasource&quot;:[{&quot;tableRule&quot;:[],&quot;srcDatasourceName&quot;:&quot;mm&quot;}]}}}]},&quot;extend&quot;:{&quot;mode&quot;:&quot;migration_holo&quot;,&quot;resourceGroup&quot;:&quot;group_219193793999490&quot;}},&quot;setting&quot;:{&quot;autoCreateWorkflow&quot;:true,&quot;userDefinedFileNameExpression&quot;:&quot;oneclick&quot;},&quot;srcType&quot;:&quot;mysql&quot;,&quot;tableMappingRuleFromRealtimeSyncConfig&quot;:{&quot;datasource&quot;:[{&quot;srcDatasourceName&quot;:&quot;mm&quot;,&quot;tableRule&quot;:[]}]}}</para>
                /// </summary>
                [NameInMap("ProcessContent")]
                [Validation(Required=false)]
                public string ProcessContent { get; set; }

                /// <summary>
                /// <para>The additional parameters of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;processType&quot;:&quot;new&quot;,&quot;tableNum&quot;:300}</para>
                /// </summary>
                [NameInMap("ProcessExtra")]
                [Validation(Required=false)]
                public string ProcessExtra { get; set; }

                /// <summary>
                /// <para>The ID of the project to which the data synchronization solution belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The type of the source of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The start time of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-07 14:40:51</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the data synchronization solution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: successful</description></item>
                /// <item><description>1: not running</description></item>
                /// <item><description>2: running</description></item>
                /// <item><description>3: failed</description></item>
                /// <item><description>4: committed</description></item>
                /// <item><description>5: pending manual confirmation</description></item>
                /// <item><description>6: manually confirmed</description></item>
                /// <item><description>7: others</description></item>
                /// <item><description>8: waiting</description></item>
                /// <item><description>9: deleted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the data synchronization solution was committed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-07 14:40:51</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// <para>The type of the data synchronization solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>holo</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the details of the real-time synchronization task or data synchronization solution are obtained. Valid values:</para>
            /// <para>success: The details are obtained. fail: The details fail to be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True</description></item>
        /// <item><description>False</description></item>
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
