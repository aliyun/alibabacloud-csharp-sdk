// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetAccessKeyLastUsedRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AccessKey pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI4GFTgcR8m8cZQDTH****</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>The name of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
