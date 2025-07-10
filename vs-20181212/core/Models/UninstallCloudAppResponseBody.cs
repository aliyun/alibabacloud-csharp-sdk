// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UninstallCloudAppResponseBody : TeaModel {
        [NameInMap("FailedInstanceCount")]
        [Validation(Required=false)]
        public int? FailedInstanceCount { get; set; }

        [NameInMap("FailedInstances")]
        [Validation(Required=false)]
        public List<UninstallCloudAppResponseBodyFailedInstances> FailedInstances { get; set; }
        public class UninstallCloudAppResponseBodyFailedInstances : TeaModel {
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public int? ErrCode { get; set; }

            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

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

        [NameInMap("SuccessInstanceCount")]
        [Validation(Required=false)]
        public int? SuccessInstanceCount { get; set; }

        [NameInMap("SuccessInstances")]
        [Validation(Required=false)]
        public List<UninstallCloudAppResponseBodySuccessInstances> SuccessInstances { get; set; }
        public class UninstallCloudAppResponseBodySuccessInstances : TeaModel {
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

        }

    }

}
