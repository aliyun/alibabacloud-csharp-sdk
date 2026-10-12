// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RefreshPluginOAuthCodeRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code returned by the Codeup OAuth authorization callback (the code parameter carried in the callback after authorization at <a href="https://codeup.aliyun.com/oauth/authorize?app_id=xxx&state=apigw">https://codeup.aliyun.com/oauth/authorize?app_id=xxx&amp;state=apigw</a>). If this parameter is empty, the ErrInvalidParameterWithEmpty(&quot;oauth code&quot;) error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4/0AX4xxxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
