// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeChangeOrderRequest : TeaModel {
        /// <summary>
        /// <para>The change order ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/126615.html">ListChangeOrders</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76fa5c0-9ebb-4bb4-b383-1f885447****</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

    }

}
