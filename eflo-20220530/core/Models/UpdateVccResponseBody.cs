// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UpdateVccResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UpdateVccResponseBodyContent Content { get; set; }
        public class UpdateVccResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The ID of the Lingjun connection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcc-cn-2r42v22cn03</para>
            /// </summary>
            [NameInMap("VccId")]
            [Validation(Required=false)]
            public string VccId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F906C4D3-7444-58E2-9819-E3D8563571A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
