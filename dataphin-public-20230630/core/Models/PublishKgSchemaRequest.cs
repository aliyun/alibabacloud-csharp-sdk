// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class PublishKgSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The publish command and its details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PublishCommand")]
        [Validation(Required=false)]
        public PublishKgSchemaRequestPublishCommand PublishCommand { get; set; }
        public class PublishKgSchemaRequestPublishCommand : TeaModel {
            /// <summary>
            /// <para>The data adjustment policies.</para>
            /// </summary>
            [NameInMap("DataAdjustmentPolicies")]
            [Validation(Required=false)]
            public List<PublishKgSchemaRequestPublishCommandDataAdjustmentPolicies> DataAdjustmentPolicies { get; set; }
            public class PublishKgSchemaRequestPublishCommandDataAdjustmentPolicies : TeaModel {
                /// <summary>
                /// <para>The backfill property default value policy. This parameter takes effect only when PolicyType is set to BackFillDefault.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("BackFillDefaultValuePolicy")]
                [Validation(Required=false)]
                public PublishKgSchemaRequestPublishCommandDataAdjustmentPoliciesBackFillDefaultValuePolicy BackFillDefaultValuePolicy { get; set; }
                public class PublishKgSchemaRequestPublishCommandDataAdjustmentPoliciesBackFillDefaultValuePolicy : TeaModel {
                    /// <summary>
                    /// <para>The default value to backfill for the property.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The property code.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("PropertyCode")]
                    [Validation(Required=false)]
                    public string PropertyCode { get; set; }

                }

                /// <summary>
                /// <para>The policy type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BackFillDefault: backfills default values when a property changes from optional to required.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BackFillDefault</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The type to which the policy applies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENTITY: applies to entity types.</description></item>
                /// <item><description>RELATION: applies to relation types.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENTITY</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The code of the entity type or relation type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product</para>
                /// </summary>
                [NameInMap("TypeCode")]
                [Validation(Required=false)]
                public string TypeCode { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
