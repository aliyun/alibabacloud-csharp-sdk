// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ResendVerifyActivateRequest : TeaModel {
        /// <summary>
        /// <para>The channel type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHONE</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

    }

}
