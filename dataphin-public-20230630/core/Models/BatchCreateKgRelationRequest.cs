// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class BatchCreateKgRelationRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public BatchCreateKgRelationRequestCreateCommand CreateCommand { get; set; }
        public class BatchCreateKgRelationRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The list of relationships.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<BatchCreateKgRelationRequestCreateCommandRelationList> RelationList { get; set; }
            public class BatchCreateKgRelationRequestCreateCommandRelationList : TeaModel {
                /// <summary>
                /// <para>The list of relationship record properties.</para>
                /// </summary>
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<BatchCreateKgRelationRequestCreateCommandRelationListPropertyList> PropertyList { get; set; }
                public class BatchCreateKgRelationRequestCreateCommandRelationListPropertyList : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The relationship type code.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Company</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The ID of the source entity record.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e1d4559a4db044158305e2d89bccf81f</para>
                /// </summary>
                [NameInMap("SourceEntityId")]
                [Validation(Required=false)]
                public string SourceEntityId { get; set; }

                /// <summary>
                /// <para>The ID of the target entity record.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e1d4559a4db044158305e2d89bccf82f</para>
                /// </summary>
                [NameInMap("TargetEntityId")]
                [Validation(Required=false)]
                public string TargetEntityId { get; set; }

            }

        }

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
        /// <para>The workspace ID.</para>
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
