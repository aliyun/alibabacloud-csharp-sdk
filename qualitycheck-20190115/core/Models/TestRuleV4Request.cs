// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TestRuleV4Request : TeaModel {
        [NameInMap("IsSchemeData")]
        [Validation(Required=false)]
        public int? IsSchemeData { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TestJson")]
        [Validation(Required=false)]
        public string TestJson { get; set; }

    }

}
