// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class InstallCloudAppResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of failed cloud application service instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedInstanceCount")]
        [Validation(Required=false)]
        public int? FailedInstanceCount { get; set; }

        /// <summary>
        /// <para>List of failed cloud application service instances</para>
        /// </summary>
        [NameInMap("FailedInstances")]
        [Validation(Required=false)]
        public List<InstallCloudAppResponseBodyFailedInstances> FailedInstances { get; set; }
        public class InstallCloudAppResponseBodyFailedInstances : TeaModel {
            /// <summary>
            /// <para>Failure error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>300000</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public int? ErrCode { get; set; }

            /// <summary>
            /// <para>Failure reason message</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rejected due to timeout</para>
            /// </summary>
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

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
        /// <para>Request ID</para>
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
        public int? SuccessInstanceCount { get; set; }

        /// <summary>
        /// <para>List of successful cloud application service instances</para>
        /// </summary>
        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<InstallCloudAppResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class InstallCloudAppResponseBodySuccessInstances : TeaModel {
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
