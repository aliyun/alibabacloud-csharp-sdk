// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaMarksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>53afdf003a******6a16b5feac6402</para>
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
        /// <para>771A1414-27BF-53E6-AB73-EFCB*****ACF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
