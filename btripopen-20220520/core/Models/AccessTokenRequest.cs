// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ggZADkghsadgogeDxdaD</para>
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
