// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateNetworkPathResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the network path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-4cbf598673d14d27****</para>
        /// </summary>
        [NameInMap("NetworkPathId")]
        [Validation(Required=false)]
        public string NetworkPathId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92DD9FFB-06FB-56F7-83EF-5CEF98F5562A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
