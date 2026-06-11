// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomAgentResponseBodyData Data { get; set; }
        public class ListCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of custom agent objects.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListCustomAgentResponseBodyDataContent> Content { get; set; }
            public class ListCustomAgentResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The parent Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16738266********</para>
                /// </summary>
                [NameInMap("AliyunParentId")]
                [Validation(Required=false)]
                public string AliyunParentId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20372822********</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                [NameInMap("CallbackConfig")]
                [Validation(Required=false)]
                public ListCustomAgentResponseBodyDataContentCallbackConfig CallbackConfig { get; set; }
                public class ListCustomAgentResponseBodyDataContentCallbackConfig : TeaModel {
                    [NameInMap("CallbackArgs")]
                    [Validation(Required=false)]
                    public string CallbackArgs { get; set; }

                    [NameInMap("CallbackPrompt")]
                    [Validation(Required=false)]
                    public string CallbackPrompt { get; set; }

                    [NameInMap("CallbackTime")]
                    [Validation(Required=false)]
                    public int? CallbackTime { get; set; }

                    [NameInMap("ToolId")]
                    [Validation(Required=false)]
                    public string ToolId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HaoY*****</para>
                /// </summary>
                [NameInMap("CreatorUserName")]
                [Validation(Required=false)]
                public string CreatorUserName { get; set; }

                /// <summary>
                /// <para>The custom agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-4y3ca4khkcu**********ysf</para>
                /// </summary>
                [NameInMap("CustomAgentId")]
                [Validation(Required=false)]
                public string CustomAgentId { get; set; }

                /// <summary>
                /// <para>The current DMS unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("DMSUnit")]
                [Validation(Required=false)]
                public string DMSUnit { get; set; }

                /// <summary>
                /// <para>The data scope, specified as a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;tableFlag&quot; : true,
                ///   &quot;scope&quot; : &quot;personal&quot;,
                ///   &quot;personal&quot; : {
                ///     &quot;DataSourceType&quot; : &quot;remote_data_center&quot;,
                ///     &quot;FileId&quot; : &quot;f-5qlrwaw10<b><b><b><b>s3gpw1z&quot;,
                ///     &quot;Database&quot; : &quot;测试表格</b></b></b>.xlsx&quot;,
                ///     &quot;Tables&quot; : [ &quot;Sheet1&quot; ],
                ///     &quot;TableIds&quot; : [ &quot;</b>****&quot; ],
                ///     &quot;RegionId&quot; : &quot;cn-hangzhou&quot;
                ///   }
                /// }</para>
                /// </summary>
                [NameInMap("DataJson")]
                [Validation(Required=false)]
                public string DataJson { get; set; }

                [NameInMap("DefaultAgent")]
                [Validation(Required=false)]
                public int? DefaultAgent { get; set; }

                /// <summary>
                /// <para>The description of the custom agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent测试描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The current DMS unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("DmsUnit")]
                [Validation(Required=false)]
                public string DmsUnit { get; set; }

                /// <summary>
                /// <para>The execution configuration.</para>
                /// </summary>
                [NameInMap("ExecutionConfig")]
                [Validation(Required=false)]
                public ListCustomAgentResponseBodyDataContentExecutionConfig ExecutionConfig { get; set; }
                public class ListCustomAgentResponseBodyDataContentExecutionConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to prevent user inquiries during the process.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SkipAskHuman")]
                    [Validation(Required=false)]
                    public bool? SkipAskHuman { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to skip the plan confirmation step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SkipPlan")]
                    [Validation(Required=false)]
                    public bool? SkipPlan { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to skip all SQL confirmations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SkipSqlConfirm")]
                    [Validation(Required=false)]
                    public bool? SkipSqlConfirm { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to skip the confirmation for generating a web report.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SkipWebReportConfirm")]
                    [Validation(Required=false)]
                    public bool? SkipWebReportConfirm { get; set; }

                }

                /// <summary>
                /// <para>The time when the agent was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The instructions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分析框架：
                /// 1、需按日、周、月维度监控核心指标（GMV、订单量、UV、转化率），分析趋势变化及同比/环比波动；
                /// 2、划分新老客、渠道、地域进行拆解，识别增长来源与短板；
                /// 3、结合用户行为路径（浏览→加购→支付）开展漏斗分析，定位流失环节；</para>
                /// </summary>
                [NameInMap("Instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent is configured with a recurring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsScheduleTask")]
                [Validation(Required=false)]
                public bool? IsScheduleTask { get; set; }

                /// <summary>
                /// <para>The provided knowledge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>核心指标定义：
                /// 1、GMV（成交总额）指订单金额总和，含已支付及未支付成功订单；
                /// 2、订单量为每日有效下单笔数；
                /// 3、UV（独立访客）指访问网站或APP的去重用户数；
                /// 4、转化率=支付订单数 / UV，反映流量转化效率；</para>
                /// </summary>
                [NameInMap("Knowledge")]
                [Validation(Required=false)]
                public string Knowledge { get; set; }

                [NameInMap("KnowledgeConfigList")]
                [Validation(Required=false)]
                public List<ListCustomAgentResponseBodyDataContentKnowledgeConfigList> KnowledgeConfigList { get; set; }
                public class ListCustomAgentResponseBodyDataContentKnowledgeConfigList : TeaModel {
                    [NameInMap("AccessType")]
                    [Validation(Required=false)]
                    public string AccessType { get; set; }

                    [NameInMap("KbUuid")]
                    [Validation(Required=false)]
                    public string KbUuid { get; set; }

                    [NameInMap("McpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                }

                /// <summary>
                /// <para>The user who last modified the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20372822********</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HaoY*****</para>
                /// </summary>
                [NameInMap("ModifierUserName")]
                [Validation(Required=false)]
                public string ModifierUserName { get; set; }

                /// <summary>
                /// <para>The name of the custom agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent测试名称</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>If a recurring task is configured, this indicates its next scheduled runtime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1767715200</para>
                /// </summary>
                [NameInMap("NextRuntime")]
                [Validation(Required=false)]
                public long? NextRuntime { get; set; }

                /// <summary>
                /// <para>The time when the agent was taken offline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("OfflineTime")]
                [Validation(Required=false)]
                public string OfflineTime { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RelatedSessionId")]
                [Validation(Required=false)]
                public string RelatedSessionId { get; set; }

                /// <summary>
                /// <para>The time when the agent was published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The recurring task configuration.</para>
                /// </summary>
                [NameInMap("ScheduleTaskConfig")]
                [Validation(Required=false)]
                public ListCustomAgentResponseBodyDataContentScheduleTaskConfig ScheduleTaskConfig { get; set; }
                public class ListCustomAgentResponseBodyDataContentScheduleTaskConfig : TeaModel {
                    /// <summary>
                    /// <para>The cron expression for the recurring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 0 0 ? * 1-7</para>
                    /// </summary>
                    [NameInMap("CronExpression")]
                    [Validation(Required=false)]
                    public string CronExpression { get; set; }

                    /// <summary>
                    /// <para>The query for the recurring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>分析一下这份数据，给出简报</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    /// <summary>
                    /// <para>The ID of the referenced historical session.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4m24*****mg7j2v</para>
                    /// </summary>
                    [NameInMap("RelatedSessionId")]
                    [Validation(Required=false)]
                    public string RelatedSessionId { get; set; }

                }

                /// <summary>
                /// <para>The status of the custom agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The formatting instructions for the text report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文字报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
                /// </summary>
                [NameInMap("TextReportConfig")]
                [Validation(Required=false)]
                public string TextReportConfig { get; set; }

                /// <summary>
                /// <para>The formatting instructions for the web report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>网页报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
                /// </summary>
                [NameInMap("WebReportConfig")]
                [Validation(Required=false)]
                public string WebReportConfig { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56kv1pvl9uvt9**********bb</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
