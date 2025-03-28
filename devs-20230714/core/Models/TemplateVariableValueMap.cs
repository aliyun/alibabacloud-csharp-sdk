// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateVariableValueMap : TeaModel {
        [NameInMap("services")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Services { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;TEST_KEY&quot;:&quot;new_value&quot;}</para>
        /// </summary>
        [NameInMap("shared")]
        [Validation(Required=false)]
        public Dictionary<string, object> Shared { get; set; }

    }

}
