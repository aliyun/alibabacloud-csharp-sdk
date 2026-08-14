// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateClusterVpcEndpointConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateClusterVpcEndpointConnectionResponseBodyData Data { get; set; }
        public class CreateClusterVpcEndpointConnectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-xxx</para>
            /// </summary>
            [NameInMap("endpointConnectionId")]
            [Validation(Required=false)]
            public string EndpointConnectionId { get; set; }

        }

        /// <summary>
        /// <para>The description of the error code. This parameter is empty if no error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
