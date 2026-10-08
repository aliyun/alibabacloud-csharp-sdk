// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyMaskingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n8t18o******6d5</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The name of the default encryption or masking algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sm4-128-gcm</para>
        /// </summary>
        [NameInMap("DefaultAlgo")]
        [Validation(Required=false)]
        public string DefaultAlgo { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is enabled. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// <para>The rule algorithms. You can specify multiple algorithms. Masking algorithms can include additional parameters. Format: {name: algorithm1}, {name: algorithm2, params: {encryption position, encryption length}}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;: &quot;sha256&quot;},
        ///         {&quot;name&quot;:&quot;sm4-128-gcm&quot;}]</para>
        /// </summary>
        [NameInMap("MaskingAlgo")]
        [Validation(Required=false)]
        public string MaskingAlgo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
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

        /// <summary>
        /// <para>The rule configuration in JSON string format.</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public ModifyMaskingRulesRequestRuleConfig RuleConfig { get; set; }
        public class ModifyMaskingRulesRequestRuleConfig : TeaModel {
            /// <summary>
            /// <para>The list of columns.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>The list of databases.</para>
            /// </summary>
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<string> Databases { get; set; }

            /// <summary>
            /// <para>The list of tables.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

        }

        /// <summary>
        /// <para>The name of the rule to modify.</para>
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
