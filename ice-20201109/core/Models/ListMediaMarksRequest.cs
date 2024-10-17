// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaMarksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>411bed50018971edb60b0764a0ec6***</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The mark ID. You can specify multiple IDs separated with commas (,). This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mark-f82d<em><b><b>4994b0915948ef7e16,mark-3d56d</b></b></em>4c8fa9ae2a1f9e5d2d60</para>
        /// </summary>
        [NameInMap("MediaMarkIds")]
        [Validation(Required=false)]
        public string MediaMarkIds { get; set; }

    }

}
