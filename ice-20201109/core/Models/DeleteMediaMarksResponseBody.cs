// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteMediaMarksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>019b82e24b37a1c2958dec38</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mark-f82d<em><b><b>4994b0915948ef7e16,mark-3d56d</b></b></em>4c8fa9ae2a1f9e5d2d60</para>
        /// </summary>
        [NameInMap("MediaMarkIds")]
        [Validation(Required=false)]
        public string MediaMarkIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
