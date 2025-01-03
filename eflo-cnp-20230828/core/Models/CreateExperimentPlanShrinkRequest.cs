// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CreateExperimentPlanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Additional parameters</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExternalParams")]
        [Validation(Required=false)]
        public string ExternalParamsShrink { get; set; }

        /// <summary>
        /// <para>Resource group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzij65sf2rr5i</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Resource ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>189</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public long? ResourceId { get; set; }

        /// <summary>
        /// <para>Template ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>349623</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
