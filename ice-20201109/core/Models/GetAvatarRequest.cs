// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAvatarRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Avatar-XXXX</para>
        /// </summary>
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

    }

}
