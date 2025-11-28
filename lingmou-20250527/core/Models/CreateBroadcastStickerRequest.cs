// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateBroadcastStickerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sticker.png</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>material/INPUT_BROADCAST_STICKER/Mt.CPRLVQRR27YU2</para>
        /// </summary>
        [NameInMap("ossKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

    }

}
