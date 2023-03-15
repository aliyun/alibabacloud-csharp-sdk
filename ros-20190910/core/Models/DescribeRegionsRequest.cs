// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The language in which the returned results are displayed.
        /// 
        /// Default value: zh-CN. Valid values:
        /// 
        /// *   zh-CN: Chinese
        /// *   en-US: English
        /// *   ja: Japanese
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
