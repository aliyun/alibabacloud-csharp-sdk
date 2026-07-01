// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeleteSessionClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The data structure of the deleted session cluster.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SessionCluster Data { get; set; }

        /// <summary>
        /// <para>This parameter is not empty and indicates the error code if \<c>success\\</c> is \<c>false\\</c>. This parameter is empty if \<c>success\\</c> is \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>This parameter is not empty and indicates the error message if \<c>success\\</c> is \<c>false\\</c>. This parameter is empty if \<c>success\\</c> is \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 is returned. The \<c>success\\</c> parameter indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-ABCD-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
