// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateEnvironmentRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The environment ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The name of the environment instance.
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// The payable resource plan. Valid values:
        /// 
        /// *   If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro. Default value: CS_Basic.
        /// *   Otherwise, leave the parameter empty.
        /// </summary>
        [NameInMap("FeePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
