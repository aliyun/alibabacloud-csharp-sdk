// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachTaskSessionResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("audioUsage")]
        [Validation(Required=false)]
        public int? AudioUsage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0：待扣费；1：完成扣费</para>
        /// </summary>
        [NameInMap("deductionStatus")]
        [Validation(Required=false)]
        public int? DeductionStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>系统异常，请联系管理员</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D902811-B75C-5D1B-8882-D515F8E2F977</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("tokenUsage")]
        [Validation(Required=false)]
        public int? TokenUsage { get; set; }

    }

}
