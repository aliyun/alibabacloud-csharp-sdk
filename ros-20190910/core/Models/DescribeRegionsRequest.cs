// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The language in which you want to display the results. Valid values:
        /// 
        /// *   zh-CN (default): Chinese
        /// *   en-US: English
        /// *   ja: Japanese
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
