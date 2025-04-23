// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class GetXtraceTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInputParams</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The gRPC endpoint used for uploading ARM traces.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://tracing-analysis-dc-hz.aliyuncs.com:8090">http://tracing-analysis-dc-hz.aliyuncs.com:8090</a></para>
        /// </summary>
        [NameInMap("GrpcEndpoint")]
        [Validation(Required=false)]
        public string GrpcEndpoint { get; set; }

        /// <summary>
        /// <para>The internal gRPC endpoint used for uploading ARMS traces used by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://tracing-analysis-dc-hz-internal.aliyuncs.com:8090">http://tracing-analysis-dc-hz-internal.aliyuncs.com:8090</a></para>
        /// </summary>
        [NameInMap("GrpcInternalEndpoint")]
        [Validation(Required=false)]
        public string GrpcInternalEndpoint { get; set; }

        /// <summary>
        /// <para>The endpoint used for uploading ARMS traces.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://tracing-analysis-dc-hz.aliyuncs.com/aaa@bbb@ccc/api/otlp/traces">http://tracing-analysis-dc-hz.aliyuncs.com/aaa@bbb@ccc/api/otlp/traces</a></para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <para>The internal endpoint used for uploading ARMS traces used by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://tracing-analysis-dc-hz-internal.aliyuncs.com/aaa@bbb@ccc/api/otlp/traces">http://tracing-analysis-dc-hz-internal.aliyuncs.com/aaa@bbb@ccc/api/otlp/traces</a></para>
        /// </summary>
        [NameInMap("HttpInternalEndpoint")]
        [Validation(Required=false)]
        public string HttpInternalEndpoint { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>get_xtrace_token: failed, ERROR: NoPermission</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A87228C-969A-1381-98CF-AE07AE630FA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The token used for uploading ARMS traces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h1abcw7@5abcb_h1abcw7@5abc01</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
