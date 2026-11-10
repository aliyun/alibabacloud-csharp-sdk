// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeAICallDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>调用明细列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CallDetails")]
        [Validation(Required=false)]
        public List<DescribeAICallDetailsResponseBodyCallDetails> CallDetails { get; set; }
        public class DescribeAICallDetailsResponseBodyCallDetails : TeaModel {
            /// <summary>
            /// <para>售卖 deduction 记录中的原始 agent_type；未匹配或 ADB 查询失败时不返回。</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIComputer</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>调用状态：SUCCESS、RATE_LIMITED、TIMEOUT 或 FAILED。</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <para>日志时间，ISO 8601。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T12:30:00+08:00</para>
            /// </summary>
            [NameInMap("CallTime")]
            [Validation(Required=false)]
            public string CallTime { get; set; }

            /// <summary>
            /// <para>首包时延，单位毫秒；失败或无首包数据时为空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>620</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("FirstTokenLatencyMs")]
            [Validation(Required=false)]
            public long? FirstTokenLatencyMs { get; set; }

            /// <summary>
            /// <para>本条调用日志的实际数据地域，取值为 cn-shanghai、cn-hangzhou、cn-hongkong、ap-southeast-1 或 us-east-1；杭州预发返回 cn-hangzhou。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("GatewayRegion")]
            [Validation(Required=false)]
            public string GatewayRegion { get; set; }

            /// <summary>
            /// <para>AI 网关返回的 HTTP 状态码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("HttpStatusCode")]
            [Validation(Required=false)]
            public int? HttpStatusCode { get; set; }

            /// <summary>
            /// <para>原始输入 token 数，前端据此转换上下文规模。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("InputToken")]
            [Validation(Required=false)]
            public long? InputToken { get; set; }

            /// <summary>
            /// <para>产品实例 ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-instance-001</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>实际调用模型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-model</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>按请求 ID 和输入输出 token 匹配的实际抵扣积分，十进制字符串；积分查询失败或超时时为空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.28896</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public string Points { get; set; }

            /// <summary>
            /// <para>本条调用已匹配抵扣记录的积分构成，与 Points 来自同一条记录。缺少有效明细时不返回此对象；对象存在时完整返回五项积分，五项之和等于 Points，真实零值返回字符串 0。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NormalInput&quot;:&quot;0.02&quot;,&quot;Output&quot;:&quot;0.1&quot;,&quot;ImplicitCacheHit&quot;:&quot;0&quot;,&quot;ExplicitCacheCreation&quot;:&quot;0.15&quot;,&quot;ExplicitCacheHit&quot;:&quot;0.01896&quot;}</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("PointsBreakdown")]
            [Validation(Required=false)]
            public DescribeAICallDetailsResponseBodyCallDetailsPointsBreakdown PointsBreakdown { get; set; }
            public class DescribeAICallDetailsResponseBodyCallDetailsPointsBreakdown : TeaModel {
                /// <summary>
                /// <para>显式缓存创建积分，单位为积分，使用十进制字符串表示；真实零值为 0。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.15</para>
                /// </summary>
                [NameInMap("ExplicitCacheCreation")]
                [Validation(Required=false)]
                public string ExplicitCacheCreation { get; set; }

                /// <summary>
                /// <para>显式缓存命中积分，单位为积分，使用十进制字符串表示；真实零值为 0。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01896</para>
                /// </summary>
                [NameInMap("ExplicitCacheHit")]
                [Validation(Required=false)]
                public string ExplicitCacheHit { get; set; }

                /// <summary>
                /// <para>隐式缓存命中积分，单位为积分，使用十进制字符串表示；真实零值为 0。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ImplicitCacheHit")]
                [Validation(Required=false)]
                public string ImplicitCacheHit { get; set; }

                /// <summary>
                /// <para>普通输入积分，单位为积分，使用十进制字符串表示；真实零值为 0。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.02</para>
                /// </summary>
                [NameInMap("NormalInput")]
                [Validation(Required=false)]
                public string NormalInput { get; set; }

                /// <summary>
                /// <para>输出积分，单位为积分，使用十进制字符串表示；真实零值为 0。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public string Output { get; set; }

            }

            /// <summary>
            /// <para>AI 网关请求 ID，与外层 POP 请求 ID 不同。</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-call-example-001</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>用户 WyId，用户名由前端组装。</para>
            /// 
            /// <b>Example:</b>
            /// <para>wy-example-001</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

        /// <summary>
        /// <para>当前页码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>当前页大小。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>实际查询终点。翻页时应复用此值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-06T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public string QueryEndTime { get; set; }

        /// <summary>
        /// <para>实际查询起点。翻页时应复用此值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public string QueryStartTime { get; set; }

        /// <summary>
        /// <para>POP 请求 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>满足条件的总记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
