// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F8C06AD-3F37-57A0-ABBF-ABD7824F55CE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateGADInstanceResponseBodyResult Result { get; set; }
        public class CreateGADInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The number of unit nodes that are created by calling this operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CreateMemberCount")]
            [Validation(Required=false)]
            public string CreateMemberCount { get; set; }

            /// <summary>
            /// <para>The ID of the global active database cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gad-rm-bp1npi2j8********</para>
            /// </summary>
            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5374xxxx</para>
            /// </summary>
            [NameInMap("TaskID")]
            [Validation(Required=false)]
            public string TaskID { get; set; }

        }

    }

}
