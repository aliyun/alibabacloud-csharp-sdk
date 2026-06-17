// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DisableSdlProtectedAssetRequest : TeaModel {
        /// <summary>
        /// <para>The list of IP assets.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<string> IpList { get; set; }

        /// <summary>
        /// <para>The language of the response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
