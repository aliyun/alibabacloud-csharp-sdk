// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ConvertDirectConversationToWorkResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败沿现有 OpenAPI/POP 错误合同返回；转换是否整体完成须同时检查 status</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>转换 ID，查询及恢复过程中保持不变</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleConversionId</para>
        /// </summary>
        [NameInMap("conversionId")]
        [Validation(Required=false)]
        public string ConversionId { get; set; }

        /// <summary>
        /// <para>固定快照中转换的完整 direct 问答轮数，不受发送接口 directMaxHistoryRounds 限制</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("convertedRounds")]
        [Validation(Required=false)]
        public int? ConvertedRounds { get; set; }

        /// <summary>
        /// <para>转换历史范围，固定为 direct；不包含普通 work 历史</para>
        /// 
        /// <b>Example:</b>
        /// <para>direct</para>
        /// </summary>
        [NameInMap("historyScope")]
        [Validation(Required=false)]
        public string HistoryScope { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>是否允许继续原转换；false 表示不另起执行，仍允许用同一源 sessionId 查询。重试或继续始终复用同一转换、目标及快照</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("retryable")]
        [Validation(Required=false)]
        public bool? Retryable { get; set; }

        /// <summary>
        /// <para>冻结快照对应的源 direct 历史 epoch</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sourceEpoch")]
        [Validation(Required=false)]
        public long? SourceEpoch { get; set; }

        /// <summary>
        /// <para>源会话 ID，与请求 sessionId 一致</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceSessionId</para>
        /// </summary>
        [NameInMap("sourceSessionId")]
        [Validation(Required=false)]
        public string SourceSessionId { get; set; }

        /// <summary>
        /// <para>转换状态：processing 表示处理中；succeeded 表示模型导入、目标登记、展示投影及两侧就绪均完成。失败按 OpenAPI/POP 错误合同处理，不能仅凭 HTTP 200 判断转换成功</para>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>新的 work 目标会话 ID，与源 ID 不同；processing 时可能返回预分配 ID，仅 succeeded 后可使用；重复查询或恢复复用原目标</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTargetSessionId</para>
        /// </summary>
        [NameInMap("targetSessionId")]
        [Validation(Required=false)]
        public string TargetSessionId { get; set; }

        /// <summary>
        /// <para>冻结快照包含的最后一个 direct 轮次序号；源会话后续轮次不自动加入目标</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("throughSequence")]
        [Validation(Required=false)]
        public long? ThroughSequence { get; set; }

        /// <summary>
        /// <para>目标会话的工作模式，固定为 work</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("workMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}
