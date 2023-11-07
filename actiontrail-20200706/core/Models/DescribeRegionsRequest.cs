// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The language in which the region names are returned. Valid values:
        /// 
        /// - zh-CN: Chinese.
        /// - en-US: English. It is the default value.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
