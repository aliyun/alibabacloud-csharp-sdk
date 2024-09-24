// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddFavoritePublicMediaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>icepublic-<b><b>7213c6050cbc66750b469701</b></b>,icepublic-<b><b>0b4697017213c6050cbc6675</b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
