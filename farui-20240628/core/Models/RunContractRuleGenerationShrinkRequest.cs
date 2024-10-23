// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractRuleGenerationShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public string AssistantShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
