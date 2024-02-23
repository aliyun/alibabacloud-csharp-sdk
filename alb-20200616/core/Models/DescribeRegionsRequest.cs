// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The supported natural language. Valid values:
        /// 
        /// *   zh-CN: **Chinese**
        /// *   en-US: **English**
        /// *   ja: **Japanese**
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
