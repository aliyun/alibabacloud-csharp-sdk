// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OpenOnsServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2068689****0272</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C5B4603-8977-4513-AB60-9C3E2F88****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
