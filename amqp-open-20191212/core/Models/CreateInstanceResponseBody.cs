// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The ID of the created instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-xxxxx</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>A message providing additional details about the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx failed,xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. This is a common parameter used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CCBB1225-C392-480E-8C7F-D09AB2CD2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
