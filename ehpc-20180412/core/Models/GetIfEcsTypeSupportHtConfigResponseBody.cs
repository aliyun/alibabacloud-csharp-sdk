// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetIfEcsTypeSupportHtConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether Hyper-Threading is enabled by default. Valid values:
        /// 
        /// *   true: Hyper-Threading is enabled by default.
        /// 
        /// *   false: Hyper-Threading is disabled by default
        /// 
        /// > By default, Hyper-Threading is not enabled for the SCC specification family, while Hyper-Threading is enabled for other specification families by default.
        /// </summary>
        [NameInMap("DefaultHtEnabled")]
        [Validation(Required=false)]
        public bool? DefaultHtEnabled { get; set; }

        /// <summary>
        /// The instance type of the ECS instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether hyper-threading is supported. Valid values:
        /// 
        /// *   true: Hyper-Threading is supported.
        /// *   false: Hyper-Threading is not supported.
        /// </summary>
        [NameInMap("SupportHtConfig")]
        [Validation(Required=false)]
        public bool? SupportHtConfig { get; set; }

    }

}
