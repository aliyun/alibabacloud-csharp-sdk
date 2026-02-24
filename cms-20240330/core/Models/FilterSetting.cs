// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class FilterSetting : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<FilterSettingConditions> Conditions { get; set; }
        public class FilterSettingConditions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>severity</para>
            /// </summary>
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EQ</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1 and 2 or 3</para>
        /// </summary>
        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

    }

}
