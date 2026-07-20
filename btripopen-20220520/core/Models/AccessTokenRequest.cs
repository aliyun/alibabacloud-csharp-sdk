// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>The API secret of the application. For information about how to obtain the secret, see <a href="/#/document/server/application-of-basic-information?handbookId=development-support">Application credentials</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ggZADk********eDxdaD</para>
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
