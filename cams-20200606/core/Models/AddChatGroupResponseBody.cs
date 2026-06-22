// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddChatGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>OK</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see the <a href="https://help.aliyun.com/document_detail/196974.html">error code list</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the API call succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The API call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The API call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The unique request code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8938****</para>
        /// </summary>
        [NameInMap("UniqueCode")]
        [Validation(Required=false)]
        public string UniqueCode { get; set; }

    }

}
