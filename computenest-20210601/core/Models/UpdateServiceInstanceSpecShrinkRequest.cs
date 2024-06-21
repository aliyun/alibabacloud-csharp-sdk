// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class UpdateServiceInstanceSpecShrinkRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public UpdateServiceInstanceSpecShrinkRequestCommodity Commodity { get; set; }
        public class UpdateServiceInstanceSpecShrinkRequestCommodity : TeaModel {
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

        }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        [NameInMap("PredefinedParametersName")]
        [Validation(Required=false)]
        public string PredefinedParametersName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
