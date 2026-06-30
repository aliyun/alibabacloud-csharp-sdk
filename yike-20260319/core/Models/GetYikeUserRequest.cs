// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetYikeUserRequest : TeaModel {
        /// <summary>
        /// <para>The username of the WonderClip sub-account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test.xxx@xxx.yikeai">test.xxx@xxx.yikeai</a></para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
