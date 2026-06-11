// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class LabelsFilter : TeaModel {
        /// <summary>
        /// <para>An array of <c>LabelMatcher</c> requirements. An object is selected only if it satisfies all of the requirements in this list (a logical AND). If provided, the list cannot be empty.</para>
        /// </summary>
        [NameInMap("allOf")]
        [Validation(Required=false)]
        public List<LabelMatcher> AllOf { get; set; }

        /// <summary>
        /// <para>An array of <c>LabelMatcher</c> requirements. An object is selected if it satisfies at least one of the requirements in this list (a logical OR). If provided, the list cannot be empty.</para>
        /// </summary>
        [NameInMap("anyOf")]
        [Validation(Required=false)]
        public List<LabelMatcher> AnyOf { get; set; }

    }

}
