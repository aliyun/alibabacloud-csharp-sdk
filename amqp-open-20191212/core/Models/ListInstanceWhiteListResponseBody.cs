// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListInstanceWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of <c>200</c> indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data, which is an array of whitelist entries. Each object in the array contains an <c>id</c> (a sequence number used for deletion) and a <c>value</c> (the actual entry, such as an IP address range or a VPC ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Data&quot;: [
        ///     {
        ///       &quot;id&quot;: 454,
        ///       &quot;value&quot;: &quot;10.1.2.1/30&quot;
        ///     }
        ///   ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The error message returned on a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx failed,xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DC68EC9-0E76-5435-B8C0-FF9492B4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code. A value of <c>200</c> indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
