// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateProductOrdersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3ed6a882-0d85-4dd8-ad36-cd8d74ab9fdb</para>
        /// </summary>
        [NameInMap("BuyProductRequestId")]
        [Validation(Required=false)]
        public string BuyProductRequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210292536260646</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ksdjf-jksd-*****slkdjf</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
