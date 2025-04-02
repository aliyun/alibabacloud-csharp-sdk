// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTensorboardSharedUrlRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the shareable link. Unit: seconds. Maximum value: 604800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("ExpireTimeSeconds")]
        [Validation(Required=false)]
        public string ExpireTimeSeconds { get; set; }

    }

}
