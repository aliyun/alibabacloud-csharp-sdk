// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetLinkInfoByUserIdRequest : TeaModel {
        /// <summary>
        /// <para>The user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
