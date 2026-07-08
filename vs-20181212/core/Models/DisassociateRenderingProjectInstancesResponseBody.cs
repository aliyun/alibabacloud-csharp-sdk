// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DisassociateRenderingProjectInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of cloud application service instances that failed to dissociate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedInstanceCount")]
        [Validation(Required=false)]
        public string FailedInstanceCount { get; set; }

        /// <summary>
        /// <para>A list of instances that failed to dissociate.</para>
        /// </summary>
        [NameInMap("FailedInstances")]
        [Validation(Required=false)]
        public List<DisassociateRenderingProjectInstancesResponseBodyFailedInstances> FailedInstances { get; set; }
        public class DisassociateRenderingProjectInstancesResponseBodyFailedInstances : TeaModel {
            /// <summary>
            /// <para>The reason for failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>会话中</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>A cloud application service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-421cd2a1125947c19fcd5c7dd2c7d31e</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of cloud application service instances that were successfully dissociated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SuccessInstanceCount")]
        [Validation(Required=false)]
        public string SuccessInstanceCount { get; set; }

        /// <summary>
        /// <para>A list of instances that were successfully dissociated.</para>
        /// </summary>
        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<DisassociateRenderingProjectInstancesResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class DisassociateRenderingProjectInstancesResponseBodySuccessInstances : TeaModel {
            /// <summary>
            /// <para>The result message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>A cloud application service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-e6cf423c787e4e43b460a788da254fe3</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

    }

}
