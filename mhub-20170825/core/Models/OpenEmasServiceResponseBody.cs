// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class OpenEmasServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20671870151****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>126D4DDD-05A5-49B1-B18C-39C4A929BFB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
