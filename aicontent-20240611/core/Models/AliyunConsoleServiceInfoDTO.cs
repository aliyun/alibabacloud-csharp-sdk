// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AliyunConsoleServiceInfoDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/product/ai-algorithm">https://www.aliyun.com/product/ai-algorithm</a></para>
        /// </summary>
        [NameInMap("buyUrl")]
        [Validation(Required=false)]
        public string BuyUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/product/ai-algorithm">https://www.aliyun.com/product/ai-algorithm</a></para>
        /// </summary>
        [NameInMap("documentUrl")]
        [Validation(Required=false)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("freeConcurrencyCount")]
        [Validation(Required=false)]
        public int? FreeConcurrencyCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("freeCount")]
        [Validation(Required=false)]
        public int? FreeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online_ai_algorithm_personalized_text_to_image_call_count</para>
        /// </summary>
        [NameInMap("serviceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AI算法模型-个性化文生图-在线按量调用</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
