// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageFacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The faces.</para>
        /// </summary>
        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<Figure> Faces { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E93D6C9-5AC0-49F9-914D-E02678D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
