// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateWorkspaceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateWorkspaceResponseBodyData Data { get; set; }
        public class UpdateWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1005565802416783361</para>
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>979071171373334529</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
