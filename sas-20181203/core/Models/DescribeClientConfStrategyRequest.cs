// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfStrategyRequest : TeaModel {
        /// <summary>
        /// The tag that is added to the server.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The value of the tag. Valid values:
        /// 
        /// *   major
        /// *   advanced
        /// *   basic
        /// </summary>
        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
