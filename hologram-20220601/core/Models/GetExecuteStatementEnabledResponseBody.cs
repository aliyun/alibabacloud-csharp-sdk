// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetExecuteStatementEnabledResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether SQL execution through OpenAPI is allowed (<c>true</c>) or not (<c>false</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The error code that is returned if the request fails (when <c>success</c> is <c>false</c>).</para>
        /// </description></item>
        /// <item><description><para>This parameter is empty if the request is successful (when <c>success</c> is <c>true</c>).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The error message that is returned if the request fails (when <c>success</c> is <c>false</c>).</para>
        /// </description></item>
        /// <item><description><para>This parameter is empty if the request is successful (when <c>success</c> is <c>true</c>).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C2ECDC1-FBAD-14A5-AA4A-96BC787FBDBC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
