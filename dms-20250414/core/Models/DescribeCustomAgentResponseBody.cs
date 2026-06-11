// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the custom agent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomAgentResponseBodyData Data { get; set; }
        public class DescribeCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the parent Alibaba Cloud account.</para>
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
            public DescribeCustomAgentResponseBodyDataCallbackConfig CallbackConfig { get; set; }
            public class DescribeCustomAgentResponseBodyDataCallbackConfig : TeaModel {
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
                /// <para>The callback time.</para>
                /// </summary>
                [NameInMap("CallbackTime")]
                [Validation(Required=false)]
                public int? CallbackTime { get; set; }

                /// <summary>
                /// <para>The tool ID.</para>
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
            /// <para>The username of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HaoY*****</para>
            /// </summary>
            [NameInMap("CreatorUserName")]
            [Validation(Required=false)]
            public string CreatorUserName { get; set; }

            /// <summary>
            /// <para>The ID of the custom agent.</para>
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
            /// <para>The data scope, formatted as a JSON string.</para>
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
            /// <para>Indicates whether this is the default agent.</para>
            /// </summary>
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
            public DescribeCustomAgentResponseBodyDataExecutionConfig ExecutionConfig { get; set; }
            public class DescribeCustomAgentResponseBodyDataExecutionConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to disable prompts that require human intervention.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SkipAskHuman")]
                [Validation(Required=false)]
                public bool? SkipAskHuman { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip the plan confirmation step.</para>
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
                /// <para>Specifies whether to skip confirmation before a web report is generated.</para>
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
            /// <para>The instruction for the agent\&quot;s analysis.</para>
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
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsScheduleTask")]
            [Validation(Required=false)]
            public bool? IsScheduleTask { get; set; }

            /// <summary>
            /// <para>The domain knowledge for the agent.</para>
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
            /// <para>The knowledge configurations.</para>
            /// </summary>
            [NameInMap("KnowledgeConfigList")]
            [Validation(Required=false)]
            public List<DescribeCustomAgentResponseBodyDataKnowledgeConfigList> KnowledgeConfigList { get; set; }
            public class DescribeCustomAgentResponseBodyDataKnowledgeConfigList : TeaModel {
                /// <summary>
                /// <para>The access type.</para>
                /// </summary>
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public string AccessType { get; set; }

                /// <summary>
                /// <para>The UUID of the knowledge base.</para>
                /// </summary>
                [NameInMap("KbUuid")]
                [Validation(Required=false)]
                public string KbUuid { get; set; }

                /// <summary>
                /// <para>The ID of the MCP server.</para>
                /// </summary>
                [NameInMap("McpServerId")]
                [Validation(Required=false)]
                public string McpServerId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user who last modified the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20372822********</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The username of the modifier.</para>
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
            /// <para>The next scheduled execution time.</para>
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

            /// <summary>
            /// <para>The ID of the related historical session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5xyz...</para>
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
            /// <para>The configuration of the scheduled task.</para>
            /// </summary>
            [NameInMap("ScheduleTaskConfig")]
            [Validation(Required=false)]
            public DescribeCustomAgentResponseBodyDataScheduleTaskConfig ScheduleTaskConfig { get; set; }
            public class DescribeCustomAgentResponseBodyDataScheduleTaskConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression for the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 ? * 1-7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>The task query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>分析一下这份数据，给出简报</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>The ID of the related historical session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4m24*****mg7j2v</para>
                /// </summary>
                [NameInMap("RelatedSessionId")]
                [Validation(Required=false)]
                public string RelatedSessionId { get; set; }

            }

            /// <summary>
            /// <para>The status of the custom agent. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELEASED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The formatting requirements for the text report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文字报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
            /// </summary>
            [NameInMap("TextReportConfig")]
            [Validation(Required=false)]
            public string TextReportConfig { get; set; }

            /// <summary>
            /// <para>The formatting requirements for the web report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>网页报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
            /// </summary>
            [NameInMap("WebReportConfig")]
            [Validation(Required=false)]
            public string WebReportConfig { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56kv1pvl9uvt9**********bb</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
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
