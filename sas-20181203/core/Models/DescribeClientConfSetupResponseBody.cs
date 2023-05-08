// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfSetupResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the Security Center agent.
        /// </summary>
        [NameInMap("ClientConf")]
        [Validation(Required=false)]
        public DescribeClientConfSetupResponseBodyClientConf ClientConf { get; set; }
        public class DescribeClientConfSetupResponseBodyClientConf : TeaModel {
            /// <summary>
            /// The configurations of the usage for the Security Center agent.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The tag that is added to the configuration.
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
            /// </summary>
            [NameInMap("StrategyTagValue")]
            [Validation(Required=false)]
            public string StrategyTagValue { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
