// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetGovernanceServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>业务失败原因码。EnableFailed 或 DisableFailed 时返回；其他状态可省略。Enabling 自动补偿期间可返回最近一次补偿异常码，但仍属于进行中状态。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Governance.DisableFailed</para>
        /// </summary>
        [NameInMap("FailureCode")]
        [Validation(Required=false)]
        public string FailureCode { get; set; }

        /// <summary>
        /// <para>可供调用方理解和处理的安全业务失败原因。EnableFailed 或 DisableFailed 时返回；其他状态可省略。Enabling 自动补偿期间可返回最近一次补偿异常说明。</para>
        /// 
        /// <b>Example:</b>
        /// <para>The service could not be disabled. Query the service status before retrying. If the problem persists, submit a ticket.</para>
        /// </summary>
        [NameInMap("FailureMessage")]
        [Validation(Required=false)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60D54503-F1F6-51B6-B6FA-A70CBDA2A68C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>AI 云治理中心服务状态。Enabled：AI 云治理中心和治理成熟度检测均开通成功；Disabled：从未开通或已正常关闭；EnableFailed：开通失败且已自动清理本次开通部分，可重新完整开通；DisableFailed：关闭失败，可能存在部分已关闭状态，可重试关闭，不能直接开通；Enabling：开通或失败后的自动补偿进行中，补偿失败仍保留该状态并继续补偿；Disabling：关闭进行中。Enabling/Disabling 需继续轮询，其他四态为结果状态。既有开通记录保持原有兼容口径；本次 API 新发起开通严格在两项均成功后返回 Enabled。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
