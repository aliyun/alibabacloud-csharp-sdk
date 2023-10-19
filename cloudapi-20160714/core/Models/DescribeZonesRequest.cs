// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// The language in which you want to use to return the description of the system policy. Valid values:
        /// 
        /// *   en: English
        /// *   zh-CN: Chinese
        /// *   ja: Japanese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
