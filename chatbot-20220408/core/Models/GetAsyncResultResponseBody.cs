// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetAsyncResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution result data of the customer service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;message&quot;:&quot;Execution completed&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F79E7305-5314-5069-A701-9591AD051902</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution status.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Value</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Success</td>
        /// <td>The task is executed.</td>
        /// </tr>
        /// <tr>
        /// <td>Runninig</td>
        /// <td>The task is being executed.</td>
        /// </tr>
        /// <tr>
        /// <td>Fail</td>
        /// <td>The task failed to be executed.</td>
        /// </tr>
        /// </tbody></table>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
