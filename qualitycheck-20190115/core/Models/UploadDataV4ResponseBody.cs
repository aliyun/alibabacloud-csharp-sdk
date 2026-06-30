// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadDataV4ResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of 200 indicates success. Other values indicate failure. Use this field to determine the cause of a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F5934C7-C223-4F0F-BBF3-5B3594***</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The details of the error if the request fails. If the request is successful, the value is &quot;successful&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. This is a unique identifier for the request that can be used for tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F5934C7-C223-4F0F-BBF3-5B3594***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Use this field to determine if the request succeeded. A value of true indicates success. A value of false or null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
