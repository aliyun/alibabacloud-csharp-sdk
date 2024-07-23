// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class RegisterCustomFaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the face.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6cc71cb44a9491093818faf9d60****</para>
        /// </summary>
        [NameInMap("FaceId")]
        [Validation(Required=false)]
        public string FaceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91AEA76D-25B5-50DF-9126-AA6BB10FDAF4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
