// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class LlmSmartCallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>P20210208152920000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.companyreg_cloud</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13518132662</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xinxuan</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;prompt\&quot;:\&quot;{\\\&quot;accountId\\\&quot;:\\\&quot;03D31F61DD6512D23F5789A439CE4CA2\\\&quot;,\\\&quot;conversationId\\\&quot;:\\\&quot;K7nBeth9\\\&quot;}\&quot;}</para>
        /// </summary>
        [NameInMap("PromptParam")]
        [Validation(Required=false)]
        public string PromptParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>robotcall_001</para>
        /// </summary>
        [NameInMap("ScenesCode")]
        [Validation(Required=false)]
        public string ScenesCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SkillType")]
        [Validation(Required=false)]
        public int? SkillType { get; set; }

        [NameInMap("StartWordParam")]
        [Validation(Required=false)]
        public string StartWordParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>msea</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

    }

}
