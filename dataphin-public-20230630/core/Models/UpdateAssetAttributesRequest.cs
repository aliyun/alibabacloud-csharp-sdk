// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateAssetAttributesRequest : TeaModel {
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateAssetAttributesRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateAssetAttributesRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The list of asset property updates. A maximum of 50 entries can be specified in a single request.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AssetAttributeUpdateList")]
            [Validation(Required=false)]
            public List<UpdateAssetAttributesRequestUpdateCommandAssetAttributeUpdateList> AssetAttributeUpdateList { get; set; }
            public class UpdateAssetAttributesRequestUpdateCommandAssetAttributeUpdateList : TeaModel {
                /// <summary>
                /// <para>The list of properties to update.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("AttributeList")]
                [Validation(Required=false)]
                public List<UpdateAssetAttributesRequestUpdateCommandAssetAttributeUpdateListAttributeList> AttributeList { get; set; }
                public class UpdateAssetAttributesRequestUpdateCommandAssetAttributeUpdateListAttributeList : TeaModel {
                    /// <summary>
                    /// <para>The property code. This value must match the AttributeCode returned by the GetAssetTypeAttributeCodes operation.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data_level</para>
                    /// </summary>
                    [NameInMap("AttributeCode")]
                    [Validation(Required=false)]
                    public string AttributeCode { get; set; }

                    /// <summary>
                    /// <para>The list of property values. For a single-value property, pass one element. For a multi-value property, pass multiple elements. Pass an empty array [] to clear the property value.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The globally unique identifier (GUID) of the asset. You can obtain this value by calling operations such as ListCatalogAssets and GetTableColumnByTableGuids.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.project_a.table_orders</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

            }

        }

    }

}
