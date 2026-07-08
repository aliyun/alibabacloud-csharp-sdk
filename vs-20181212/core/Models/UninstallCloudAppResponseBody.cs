// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UninstallCloudAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of cloud application service instances that failed.</para>
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
        public List<UninstallCloudAppResponseBodyFailedInstances> FailedInstances { get; set; }
        public class UninstallCloudAppResponseBodyFailedInstances : TeaModel {
            /// <summary>
            /// <para>Error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>300000</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public int? ErrCode { get; set; }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rejected due to timeout</para>
            /// </summary>
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <para>Cloud application instance ID</para>
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
        /// <para>Number of successfully uninstalled cloud application instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SuccessInstanceCount")]
        [Validation(Required=false)]
        public int? SuccessInstanceCount { get; set; }

        /// <summary>
        /// <para>A list of service instances for which the cloud application was uninstalled successfully.</para>
        /// </summary>
        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<UninstallCloudAppResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class UninstallCloudAppResponseBodySuccessInstances : TeaModel {
            /// <summary>
            /// <para>Cloud application instance ID</para>
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
