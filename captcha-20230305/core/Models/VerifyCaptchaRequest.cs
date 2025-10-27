// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Captcha20230305.Models
{
    public class VerifyCaptchaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dsjidsjidsjkds*djsjdiskds</para>
        /// </summary>
        [NameInMap("CaptchaVerifyParam")]
        [Validation(Required=false)]
        public string CaptchaVerifyParam { get; set; }

    }

}
