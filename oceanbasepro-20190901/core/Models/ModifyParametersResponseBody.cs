// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>ModifyParameters</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Example 1</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public ModifyParametersResponseBodyResults Results { get; set; }
        public class ModifyParametersResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>schedule timeout.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
