// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ScaleInApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the change process for this operation. You can call the GetChangeOrderInfo operation to query the progress of this scale-in. For more information, see <a href="https://help.aliyun.com/document_detail/62072.html">GetChangeOrderInfo</a>. No ID is generated if the ForceStatus parameter is set to true. You can check whether the request is successful based on the value of the Code parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddf5a4c7-a507-4a6e****************</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
