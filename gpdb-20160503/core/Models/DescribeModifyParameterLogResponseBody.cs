// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModifyParameterLogResponseBody : TeaModel {
        /// <summary>
        /// The queried parameter modification logs.
        /// </summary>
        [NameInMap("Changelogs")]
        [Validation(Required=false)]
        public List<DescribeModifyParameterLogResponseBodyChangelogs> Changelogs { get; set; }
        public class DescribeModifyParameterLogResponseBodyChangelogs : TeaModel {
            /// <summary>
            /// The effective time.
            /// </summary>
            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// Indicates whether the modification takes effect.
            /// </summary>
            [NameInMap("ParameterValid")]
            [Validation(Required=false)]
            public string ParameterValid { get; set; }

            /// <summary>
            /// The original value of the parameter.
            /// </summary>
            [NameInMap("ParameterValueAfter")]
            [Validation(Required=false)]
            public string ParameterValueAfter { get; set; }

            /// <summary>
            /// The new value of the parameter.
            /// </summary>
            [NameInMap("ParameterValueBefore")]
            [Validation(Required=false)]
            public string ParameterValueBefore { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
