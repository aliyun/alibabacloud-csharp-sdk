// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyMaskingRulesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DefaultAlgo")]
        [Validation(Required=false)]
        public string DefaultAlgo { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        [NameInMap("MaskingAlgo")]
        [Validation(Required=false)]
        public string MaskingAlgo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public ModifyMaskingRulesRequestRuleConfig RuleConfig { get; set; }
        public class ModifyMaskingRulesRequestRuleConfig : TeaModel {
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<string> Databases { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
