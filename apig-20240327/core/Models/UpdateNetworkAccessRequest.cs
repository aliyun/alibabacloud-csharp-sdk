// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateNetworkAccessRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private&amp;pubnet</para>
        /// </summary>
        [NameInMap("networkAccessType")]
        [Validation(Required=false)]
        public string NetworkAccessType { get; set; }

    }

}
