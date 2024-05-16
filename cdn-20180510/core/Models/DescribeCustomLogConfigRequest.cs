// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCustomLogConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the custom configuration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

    }

}
