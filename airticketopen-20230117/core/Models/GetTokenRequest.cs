// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// <para>appKey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fu1bltcu3400iurywuri</para>
        /// </summary>
        [NameInMap("app_key")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>appSecret</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZzQ3MW1mb3E1ODAwI2ldUjYlWUdJn5YI</para>
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
