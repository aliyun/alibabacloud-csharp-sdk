// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ModifyCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyCustomAgentResponseBodyData Data { get; set; }
        public class ModifyCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The main Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16738266********</para>
            /// </summary>
            [NameInMap("AliyunParentUid")]
            [Validation(Required=false)]
            public string AliyunParentUid { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20372822********</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The callback configuration.</para>
            /// </summary>
            [NameInMap("CallbackConfig")]
            [Validation(Required=false)]
            public ModifyCustomAgentResponseBodyDataCallbackConfig CallbackConfig { get; set; }
            public class ModifyCustomAgentResponseBodyDataCallbackConfig : TeaModel {
                /// <summary>
                /// <para>The callback arguments.</para>
                /// </summary>
                [NameInMap("CallbackArgs")]
                [Validation(Required=false)]
                public string CallbackArgs { get; set; }

                /// <summary>
                /// <para>The callback prompt.</para>
                /// </summary>
                [NameInMap("CallbackPrompt")]
                [Validation(Required=false)]
                public string CallbackPrompt { get; set; }

                /// <summary>
                /// <para>The callback timestamp.</para>
                /// </summary>
                [NameInMap("CallbackTime")]
                [Validation(Required=false)]
                public int? CallbackTime { get; set; }

                /// <summary>
                /// <para>The ID of the tool to be called.</para>
                /// </summary>
                [NameInMap("ToolId")]
                [Validation(Required=false)]
                public string ToolId { get; set; }

                /// <summary>
                /// <para>The callback type.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Name of the user who created the agent.</para>
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
            /// <para>The data scope in JSON format.</para>
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

            /// <summary>
            /// <para>The custom agent description.</para>
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
            public ModifyCustomAgentResponseBodyDataExecutionConfig ExecutionConfig { get; set; }
            public class ModifyCustomAgentResponseBodyDataExecutionConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to skip asking for human input during execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SkipAskHuman")]
                [Validation(Required=false)]
                public bool? SkipAskHuman { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip plan confirmation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SkipPlan")]
                [Validation(Required=false)]
                public bool? SkipPlan { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip all SQL confirmations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SkipSqlConfirm")]
                [Validation(Required=false)]
                public bool? SkipSqlConfirm { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip web report confirmation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SkipWebReportConfirm")]
                [Validation(Required=false)]
                public bool? SkipWebReportConfirm { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instruction for the agent.</para>
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
            /// <para>Indicates whether a scheduled task is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsScheduleTask")]
            [Validation(Required=false)]
            public bool? IsScheduleTask { get; set; }

            /// <summary>
            /// <para>The text-based knowledge for the agent.</para>
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

            /// <summary>
            /// <para>Configurations for external knowledge bases.</para>
            /// </summary>
            [NameInMap("KnowledgeConfigList")]
            [Validation(Required=false)]
            public List<ModifyCustomAgentResponseBodyDataKnowledgeConfigList> KnowledgeConfigList { get; set; }
            public class ModifyCustomAgentResponseBodyDataKnowledgeConfigList : TeaModel {
                /// <summary>
                /// <para>The access type.</para>
                /// <list type="bullet">
                /// <item><description>mcp: Connects via MCP.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mcp</para>
                /// </summary>
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public string AccessType { get; set; }

                /// <summary>
                /// <para>The knowledge base UUID.</para>
                /// </summary>
                [NameInMap("KbUuid")]
                [Validation(Required=false)]
                public string KbUuid { get; set; }

                /// <summary>
                /// <para>The MCP server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nhdpt9adf6ac**********ca</para>
                /// </summary>
                [NameInMap("McpServerId")]
                [Validation(Required=false)]
                public string McpServerId { get; set; }

            }

            /// <summary>
            /// <para>ID of the last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20372822********</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>Name of the user who last modified the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HaoY*****</para>
            /// </summary>
            [NameInMap("ModifierUserName")]
            [Validation(Required=false)]
            public string ModifierUserName { get; set; }

            /// <summary>
            /// <para>The custom agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent测试名称</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The next runtime for the scheduled task.</para>
            /// <list type="bullet">
            /// <item><description>This value is a UNIX timestamp.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1767715200</para>
            /// </summary>
            [NameInMap("NextRuntime")]
            [Validation(Required=false)]
            public long? NextRuntime { get; set; }

            /// <summary>
            /// <para>The offline time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("OfflineTime")]
            [Validation(Required=false)]
            public string OfflineTime { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of a reference session.</para>
            /// </summary>
            [NameInMap("RelatedSessionId")]
            [Validation(Required=false)]
            public string RelatedSessionId { get; set; }

            /// <summary>
            /// <para>The release time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// <para>The scheduled task configuration.</para>
            /// </summary>
            [NameInMap("ScheduleTaskConfig")]
            [Validation(Required=false)]
            public ModifyCustomAgentResponseBodyDataScheduleTaskConfig ScheduleTaskConfig { get; set; }
            public class ModifyCustomAgentResponseBodyDataScheduleTaskConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 ? * 1-7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>The query for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分析一下这份数据，给出简报</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>The ID of a reference session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4m24*****mg7j2v</para>
                /// </summary>
                [NameInMap("RelatedSessionId")]
                [Validation(Required=false)]
                public string RelatedSessionId { get; set; }

            }

            /// <summary>
            /// <para>The agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELEASED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Formatting requirements for the text report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文字报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
            /// </summary>
            [NameInMap("TextReportConfig")]
            [Validation(Required=false)]
            public string TextReportConfig { get; set; }

            /// <summary>
            /// <para>Formatting requirements for the web report.</para>
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
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
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
