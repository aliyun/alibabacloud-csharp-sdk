// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDefaultDriveRequest : TeaModel {
        /// <summary>
        /// <para>The user ID. If you use an AccessKey pair for authentication, you must specify this parameter. If you use an access token for authentication, this parameter is optional. By default, the user ID associated with the access token is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9b7a5aa04d14ae3867fdc886fa01da4</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
