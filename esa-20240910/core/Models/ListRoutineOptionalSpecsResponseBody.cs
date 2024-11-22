// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineOptionalSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890ABCDEF01234567890ABCDEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The available specifications.</para>
        /// </summary>
        [NameInMap("Specs")]
        [Validation(Required=false)]
        public List<ListRoutineOptionalSpecsResponseBodySpecs> Specs { get; set; }
        public class ListRoutineOptionalSpecsResponseBodySpecs : TeaModel {
            /// <summary>
            /// <para>Indicates whether the specification is available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <para>The specification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ms</para>
            /// </summary>
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

        }

    }

}
