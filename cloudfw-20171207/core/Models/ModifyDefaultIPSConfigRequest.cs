// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyDefaultIPSConfigRequest : TeaModel {
        [NameInMap("AiRules")]
        [Validation(Required=false)]
        public string AiRules { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public string BasicRules { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public string CtiRules { get; set; }

        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public string EnableAllPatch { get; set; }

        [NameInMap("EnableDefault")]
        [Validation(Required=false)]
        public string EnableDefault { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public string PatchRules { get; set; }

        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
