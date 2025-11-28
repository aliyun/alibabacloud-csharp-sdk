// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateBackgroundPicRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1.jpg</para>
        /// </summary>
        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>material/INPUT_CHAT_BACKGROUND_PIC/Mt.CN2VNOPRC5QU2</para>
        /// </summary>
        [NameInMap("ossKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

    }

}
