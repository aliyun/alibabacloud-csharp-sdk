// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginSchemasRequest : TeaModel {
        /// <summary>
        /// The language that is used to return the descriptions of the access control policies. Default value: zh-CN. Valid values:
        /// 
        /// *   zh-CN (default value): Chinese
        /// *   en: English
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
