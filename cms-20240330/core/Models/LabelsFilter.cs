// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class LabelsFilter : TeaModel {
        /// <summary>
        /// <para>Match all labels (AND).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;:&quot;production&quot;},{&quot;key&quot;:&quot;team&quot;,&quot;value&quot;:&quot;ops&quot;}]</para>
        /// </summary>
        [NameInMap("allOf")]
        [Validation(Required=false)]
        public List<LabelMatcher> AllOf { get; set; }

        /// <summary>
        /// <para>Match any label (OR).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;:&quot;production&quot;},{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;:&quot;staging&quot;}]</para>
        /// </summary>
        [NameInMap("anyOf")]
        [Validation(Required=false)]
        public List<LabelMatcher> AnyOf { get; set; }

    }

}
