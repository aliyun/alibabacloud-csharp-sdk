// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClustersRequest : TeaModel {
        /// <summary>
        /// The scenario where master instances are used. Valid values:
        /// 
        /// *   `Default`: standard scenarios.
        /// *   `XFlow`: workflow scenarios.
        /// 
        /// Default value: `Default`.
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

    }

}
