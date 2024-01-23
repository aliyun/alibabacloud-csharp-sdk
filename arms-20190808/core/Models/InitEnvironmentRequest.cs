// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InitEnvironmentRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The ID of the environment instance.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// type of managed:
        /// - none: not managed. default value of prometheus for ACK.
        /// - agent: managed agent. default value of promehtues for ASK/ACS/AckOne.
        /// - agent-exproter: maanged agent and exporter. default of prometheus for Cloud.
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
