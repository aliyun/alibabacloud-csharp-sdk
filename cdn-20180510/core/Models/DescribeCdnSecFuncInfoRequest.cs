// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSecFuncInfoRequest : TeaModel {
        /// <summary>
        /// The language.
        /// 
        /// *   en: English
        /// *   zh: Chinese
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the security feature. Valid values:
        /// 
        /// *   CipherSuiteGroupCustomize: custom cipher suite.
        /// *   CipherSuiteGroupStrict: dustom cipher suite.
        /// </summary>
        [NameInMap("SecFuncType")]
        [Validation(Required=false)]
        public string SecFuncType { get; set; }

    }

}
