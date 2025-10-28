// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RollbackApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The change process ID. You can call the GetChangeOrderInfo operation to query the progress of this rollback. For more information, see <a href="https://help.aliyun.com/document_detail/423155.html">GetChangeOrderInfo</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>921026b8-d1be-************</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-*********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
