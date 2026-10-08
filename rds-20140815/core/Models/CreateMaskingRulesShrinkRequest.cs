// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateMaskingRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n8t18o3*****d5</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The name of the default encryption or masking algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aes-128-gcm</para>
        /// </summary>
        [NameInMap("DefaultAlgo")]
        [Validation(Required=false)]
        public string DefaultAlgo { get; set; }

        /// <summary>
        /// <para>The rule algorithms. You can specify multiple algorithms. Masking algorithms can include additional parameters. Format: {name: algorithm1}, {name: algorithm2, params: {encryption position, encryption length}}.</para>
        /// 
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
        /// <para>The rule configuration in JSON string format, which contains matching rules for databases, tables, and columns.</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfigShrink { get; set; }

        /// <summary>
        /// <para>The rule name. Only one rule name can be specified at a time.</para>
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
