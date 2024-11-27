// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTraceQueryByMsgIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the query task. You can call the <a href="https://help.aliyun.com/document_detail/59832.html">OnsTraceGetResult</a> operation to query the details of the message trace based on the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>272967562652883649157096685****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B93332A3-160D-404F-880F-1F8736D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
