// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryModelGroupsByApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ModelRouterQueryModelGroupsByApiKeyResponseBodyData Data { get; set; }
        public class ModelRouterQueryModelGroupsByApiKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the department to which the key belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("clientId")]
            [Validation(Required=false)]
            public long? ClientId { get; set; }

            /// <summary>
            /// <para>The list of bound model groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("groups")]
            [Validation(Required=false)]
            public List<ModelGroupDTO> Groups { get; set; }

            /// <summary>
            /// <para>The list of individually authorized model IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[200]</para>
            /// </summary>
            [NameInMap("standaloneModelList")]
            [Validation(Required=false)]
            public List<long?> StandaloneModelList { get; set; }

        }

        /// <summary>
        /// <para>The error message code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unknown error</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
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
