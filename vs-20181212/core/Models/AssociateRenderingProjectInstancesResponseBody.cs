// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class AssociateRenderingProjectInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of failed cloud application service instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedInstanceCount")]
        [Validation(Required=false)]
        public string FailedInstanceCount { get; set; }

        /// <summary>
        /// <para>List of instances that failed to associate</para>
        /// </summary>
        [NameInMap("FailedInstances")]
        [Validation(Required=false)]
        public List<AssociateRenderingProjectInstancesResponseBodyFailedInstances> FailedInstances { get; set; }
        public class AssociateRenderingProjectInstancesResponseBodyFailedInstances : TeaModel {
            /// <summary>
            /// <para>Failure reason</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid id</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Cloud application service instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-b45f28650ffe4591bf4c5c95996a428c</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of successful cloud application service instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SuccessInstanceCount")]
        [Validation(Required=false)]
        public string SuccessInstanceCount { get; set; }

        /// <summary>
        /// <para>List of successfully associated instances</para>
        /// </summary>
        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<AssociateRenderingProjectInstancesResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class AssociateRenderingProjectInstancesResponseBodySuccessInstances : TeaModel {
            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Cloud application service instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-5130e2feb23f442fb9456a3d977f03d4</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

    }

}
