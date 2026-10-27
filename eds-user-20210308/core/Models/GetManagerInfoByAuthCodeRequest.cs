// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class GetManagerInfoByAuthCodeRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code. The code is obtained by the authorized enterprise account by calling CreateAuthCode and then used by the corresponding service provider account within the validity period. If the calling account does not match the service provider specified by the authorization code, the request is rejected.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e49cd070452f0044813a467d4743****</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

    }

}
