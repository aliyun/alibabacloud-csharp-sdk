// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class BatchCreateKgEntityRequest : TeaModel {
        /// <summary>
        /// <para>The create instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public BatchCreateKgEntityRequestCreateCommand CreateCommand { get; set; }
        public class BatchCreateKgEntityRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The list of entity records.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("EntityList")]
            [Validation(Required=false)]
            public List<BatchCreateKgEntityRequestCreateCommandEntityList> EntityList { get; set; }
            public class BatchCreateKgEntityRequestCreateCommandEntityList : TeaModel {
                /// <summary>
                /// <para>The entity type code.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Company</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The list of entity record properties.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<BatchCreateKgEntityRequestCreateCommandEntityListPropertyList> PropertyList { get; set; }
                public class BatchCreateKgEntityRequestCreateCommandEntityListPropertyList : TeaModel {
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
