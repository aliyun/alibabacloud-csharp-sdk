// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfSetupRequest : TeaModel {
        /// <summary>
        /// The tag that is added to the server.
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
