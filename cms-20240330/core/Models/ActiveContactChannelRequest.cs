// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ActiveContactChannelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0b9377d9c56b5c2ea8a41a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn_hangzhou</para>
        /// </summary>
        [NameInMap("site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
