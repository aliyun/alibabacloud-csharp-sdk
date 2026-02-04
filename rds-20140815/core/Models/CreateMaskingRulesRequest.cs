// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateMaskingRulesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n8t18o3*****d5</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aes-128-gcm</para>
        /// </summary>
        [NameInMap("DefaultAlgo")]
        [Validation(Required=false)]
        public string DefaultAlgo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;: &quot;aes-128-gcm&quot;},
        ///         {&quot;name&quot;:&quot;sm4-128-gcm&quot;}]</para>
        /// </summary>
        [NameInMap("MaskingAlgo")]
        [Validation(Required=false)]
        public string MaskingAlgo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public CreateMaskingRulesRequestRuleConfig RuleConfig { get; set; }
        public class CreateMaskingRulesRequestRuleConfig : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rulename1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
