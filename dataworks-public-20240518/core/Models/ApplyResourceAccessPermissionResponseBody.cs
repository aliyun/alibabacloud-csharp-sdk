// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApplyResourceAccessPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of request order IDs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<string> Data { get; set; }

        /// <summary>
        /// <para>The request ID. Used for log identification and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
