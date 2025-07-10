// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateAlidingAssistantShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("AssistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string ExtShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fallbackContent</para>
        /// </summary>
        [NameInMap("FallbackContent")]
        [Validation(Required=false)]
        public string FallbackContent { get; set; }

        [NameInMap("Feature")]
        [Validation(Required=false)]
        public string FeatureShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lADPDetfgMsFFUvNAkjNAkg</para>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecommendPrompts")]
        [Validation(Required=false)]
        public string RecommendPromptsShrink { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("WelcomeContent")]
        [Validation(Required=false)]
        public string WelcomeContent { get; set; }

    }

}
