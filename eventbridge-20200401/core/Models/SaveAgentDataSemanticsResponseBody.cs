// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SaveAgentDataSemanticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The update result. If the save is successful, an empty object is returned with no additional business fields. If none of the four knowledge categories are specified, the target state is all four categories empty: if a non-empty current version exists, an all-empty version is published. If the current version is already all empty or no current version exists, the operation succeeds idempotently and the current round of pending generation results is finalized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The response message. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid data semantics request.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4DF-548C-B8A1-F2A8D2F4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
