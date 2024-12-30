// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetUserRequest : TeaModel {
        /// <summary>
        /// <para>The user ID. If you use an AccessKey pair to access Drive and Photo Service, you must specify this parameter. If you use an access token to access Drive and Photo Service, you do not need to specify this parameter, and Drive and Photo Service automatically finds the user ID contained in the access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9b7a5aa04d14ae3867fdc886fa01da4</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
