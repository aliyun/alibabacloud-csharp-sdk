// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterSaveFlowConfigRequest : TeaModel {
        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>607</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// <para>The requests per minute (RPM) limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("rpm")]
        [Validation(Required=false)]
        public int? Rpm { get; set; }

        /// <summary>
        /// <para>Specifies whether smooth rate limiting is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("smoothFlowEnabled")]
        [Validation(Required=false)]
        public bool? SmoothFlowEnabled { get; set; }

        /// <summary>
        /// <para>The tokens per minute (TPM) limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tpm")]
        [Validation(Required=false)]
        public int? Tpm { get; set; }

    }

}
