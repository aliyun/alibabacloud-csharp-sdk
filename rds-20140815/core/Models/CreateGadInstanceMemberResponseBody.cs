// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGadInstanceMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16C62438-491B-5C02-9B49-BA924A1372A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateGadInstanceMemberResponseBodyResult Result { get; set; }
        public class CreateGadInstanceMemberResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The number of unit nodes that are created by calling this operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CreateCount")]
            [Validation(Required=false)]
            public string CreateCount { get; set; }

            /// <summary>
            /// <para>The ID of the global active database cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gad-rm-bp1npi2j8********</para>
            /// </summary>
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }

        }

    }

}
