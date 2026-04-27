// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterSaveFlowConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>607</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("rpm")]
        [Validation(Required=false)]
        public int? Rpm { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("smoothFlowEnabled")]
        [Validation(Required=false)]
        public bool? SmoothFlowEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tpm")]
        [Validation(Required=false)]
        public int? Tpm { get; set; }

    }

}
