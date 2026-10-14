// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RenewInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The common parameter. Each request has a unique ID that can be used for troubleshooting and locating issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86A6D421-A0C7-4C01-8648-47377CA6A2CE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
