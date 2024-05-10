// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientConfSetupRequest : TeaModel {
        /// <summary>
        /// The configurations of the Security Center agent.
        /// 
        /// *   cpu: the maximum CPU utilization that can be occupied by the Security Center agent on the server
        /// *   mem: the maximum memory usage that can be occupied by the Security Center agent on the server
        /// </summary>
        [NameInMap("StrategyConfig")]
        [Validation(Required=false)]
        public string StrategyConfig { get; set; }

        /// <summary>
        /// The type of the tag.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyTag")]
        [Validation(Required=false)]
        public string StrategyTag { get; set; }

        /// <summary>
        /// The value of the tag. Valid values:
        /// 
        /// *   major
        /// *   advanced
        /// *   basic
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyTagValue")]
        [Validation(Required=false)]
        public string StrategyTagValue { get; set; }

    }

}
