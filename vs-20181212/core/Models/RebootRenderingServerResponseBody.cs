// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RebootRenderingServerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedInstanceCount")]
        [Validation(Required=false)]
        public int? FailedInstanceCount { get; set; }

        [NameInMap("FailedInstances")]
        [Validation(Required=false)]
        public List<RebootRenderingServerResponseBodyFailedInstances> FailedInstances { get; set; }
        public class RebootRenderingServerResponseBodyFailedInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>300000</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public int? ErrCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Rejected due to timeout</para>
            /// </summary>
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>render-421cd2a1125947c19fcd5c7dd2c7d31e</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SuccessInstanceCount")]
        [Validation(Required=false)]
        public int? SuccessInstanceCount { get; set; }

        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<RebootRenderingServerResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class RebootRenderingServerResponseBodySuccessInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>render-e6cf423c787e4e43b460a788da254fe3</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

    }

}
