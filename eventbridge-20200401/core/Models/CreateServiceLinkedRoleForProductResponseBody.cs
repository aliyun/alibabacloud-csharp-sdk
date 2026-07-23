// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateServiceLinkedRoleForProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. \<c>Success\\</c> indicates that the request was successful. For more information about error codes, see the Error codes section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: a 2xx status code.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: a 3xx status code.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: a 4xx status code.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: a 5xx status code.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is not specified, all HTTP status codes are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The returned message. If the request is successful, \<c>success\\</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C36345A1-75F3-5A1A-BFCF-33B8271971FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. If the request is successful, \<c>true\\</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
