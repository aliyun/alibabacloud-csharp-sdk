// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BMed20261116.Models
{
    public class OpenServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the order associated with the activation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000000000000001</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("spInstanceId")]
        [Validation(Required=false)]
        public string SpInstanceId { get; set; }

        /// <summary>
        /// <para>The service activation status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
