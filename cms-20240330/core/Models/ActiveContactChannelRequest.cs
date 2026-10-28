// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ActiveContactChannelRequest : TeaModel {
        /// <summary>
        /// <para>The activation verification code. This 32-character string is sent by the system to the mobile phone number or email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b9377d9c56b5c2ea8a41a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The site. Valid values: cn_hangzhou (China site) and ap_southeast_1 (International site). Default value: cn_hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn_hangzhou</para>
        /// </summary>
        [NameInMap("site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
