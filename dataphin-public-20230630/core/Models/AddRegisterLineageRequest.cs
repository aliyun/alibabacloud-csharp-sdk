// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddRegisterLineageRequest : TeaModel {
        /// <summary>
        /// <para>The command to register data lineage.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddRegisterLineageCommand")]
        [Validation(Required=false)]
        public AddRegisterLineageRequestAddRegisterLineageCommand AddRegisterLineageCommand { get; set; }
        public class AddRegisterLineageRequestAddRegisterLineageCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether to check the existence of the asset itself. Default value: false.</para>
            /// </summary>
            [NameInMap("CheckAssetExist")]
            [Validation(Required=false)]
            public bool? CheckAssetExist { get; set; }

            /// <summary>
            /// <para>The detailed lineages. For tables, the detailed lineages refer to field lineages. Leave this parameter empty if you do not want to add field lineages.</para>
            /// </summary>
            [NameInMap("DetailedLineages")]
            [Validation(Required=false)]
            public List<AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineages> DetailedLineages { get; set; }
            public class AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineages : TeaModel {
                /// <summary>
                /// <para>Specifies whether the lineage is direct. Default value: true.</para>
                /// </summary>
                [NameInMap("IsDirect")]
                [Validation(Required=false)]
                public bool? IsDirect { get; set; }

                /// <summary>
                /// <para>The source asset reference.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesSource Source { get; set; }
                public class AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesSource : TeaModel {
                    /// <summary>
                    /// <para>The catalog of the asset. For tables, the catalog of compute source tables or logical tables is uniformly set to Dataphin. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dataphin</para>
                    /// </summary>
                    [NameInMap("Catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    /// <summary>
                    /// <para>The environment to which the asset belongs. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV, PROD</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The extended properties.</para>
                    /// </summary>
                    [NameInMap("ExtProperties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtProperties { get; set; }

                    /// <summary>
                    /// <para>The GUID of the asset. This parameter is required when ReferenceType is set to BY_GUID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1.column1</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <para>The asset type. Specify this parameter based on the actual scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COLUMN</para>
                    /// </summary>
                    [NameInMap("MetadataType")]
                    [Validation(Required=false)]
                    public string MetadataType { get; set; }

                    /// <summary>
                    /// <para>The name of the asset. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>column1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The GUID of the parent asset. If the current object is a field, the parentGuid is the GUID of the table to which the field belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1</para>
                    /// </summary>
                    [NameInMap("ParentGuid")]
                    [Validation(Required=false)]
                    public string ParentGuid { get; set; }

                    /// <summary>
                    /// <para>The asset reference data type. Valid values: BY_GUID and BY_PROPERTY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BY_GUID, BY_PROPERTY</para>
                    /// </summary>
                    [NameInMap("ReferenceType")]
                    [Validation(Required=false)]
                    public string ReferenceType { get; set; }

                    /// <summary>
                    /// <para>The schema of the asset. For tables, this is generally a project or a business unit. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project1, bizUnit1</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                /// <summary>
                /// <para>The target asset reference.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesTarget Target { get; set; }
                public class AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesTarget : TeaModel {
                    /// <summary>
                    /// <para>The catalog of the asset. For tables, the catalog of compute source tables or logical tables is uniformly set to Dataphin. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dataphin</para>
                    /// </summary>
                    [NameInMap("Catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    /// <summary>
                    /// <para>The environment to which the asset belongs. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV, PROD</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The extended properties.</para>
                    /// </summary>
                    [NameInMap("ExtProperties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtProperties { get; set; }

                    /// <summary>
                    /// <para>The GUID of the asset. This parameter is required when ReferenceType is set to BY_GUID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1.column1</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <para>The asset type. Specify this parameter based on the actual scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COLUMN</para>
                    /// </summary>
                    [NameInMap("MetadataType")]
                    [Validation(Required=false)]
                    public string MetadataType { get; set; }

                    /// <summary>
                    /// <para>The name of the asset. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>column1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The GUID of the parent asset. If the current object is a field, the parentGuid is the GUID of the table to which the field belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1</para>
                    /// </summary>
                    [NameInMap("ParentGuid")]
                    [Validation(Required=false)]
                    public string ParentGuid { get; set; }

                    /// <summary>
                    /// <para>The asset reference data type. Valid values: BY_GUID and BY_PROPERTY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BY_GUID, BY_PROPERTY</para>
                    /// </summary>
                    [NameInMap("ReferenceType")]
                    [Validation(Required=false)]
                    public string ReferenceType { get; set; }

                    /// <summary>
                    /// <para>The schema of the asset. For tables, this is generally a project or a business unit. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project1, bizUnit1</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

            }

            /// <summary>
            /// <para>The lineage relationship properties.</para>
            /// </summary>
            [NameInMap("RelationProperties")]
            [Validation(Required=false)]
            public Dictionary<string, object> RelationProperties { get; set; }

            /// <summary>
            /// <para>The source asset.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public AddRegisterLineageRequestAddRegisterLineageCommandSource Source { get; set; }
            public class AddRegisterLineageRequestAddRegisterLineageCommandSource : TeaModel {
                /// <summary>
                /// <para>The catalog of the asset. For tables, the catalog of compute source tables or logical tables is uniformly set to Dataphin. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataphin</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The environment to which the asset belongs. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV, PROD</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The extended properties.</para>
                /// </summary>
                [NameInMap("ExtProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtProperties { get; set; }

                /// <summary>
                /// <para>The GUID of the asset. This parameter is required when ReferenceType is set to BY_GUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.300000001.project1.table1</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The subtype of the asset. Specify this parameter only when MetadataType is set to TABLE and ReferenceType is not set to BY_GUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICAL_TABLE, PHYSICAL_VIEW, PHYSICAL_MATERIALIZED_VIEW, DATASOURCE_TABLE, DATASOURCE_VIEW, DATASOURCE_MATERIALIZED_VIEW, DIM_NORMAL, DIM_LEVEL, DIM_ENUM, DIM_VIRTUAL, FACT_EVENT, FACT_PROCESS, FACT_SNAPSHOT, SUM_BIZ_UNIT</para>
                /// </summary>
                [NameInMap("MetadataSubType")]
                [Validation(Required=false)]
                public string MetadataSubType { get; set; }

                /// <summary>
                /// <para>The Asset Type. Specify this parameter as needed.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("MetadataType")]
                [Validation(Required=false)]
                public string MetadataType { get; set; }

                /// <summary>
                /// <para>The name of the asset. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The reference data type of the asset. Valid values: BY_GUID and BY_PROPERTY.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BY_GUID, BY_PROPERTY</para>
                /// </summary>
                [NameInMap("ReferenceType")]
                [Validation(Required=false)]
                public string ReferenceType { get; set; }

                /// <summary>
                /// <para>The schema of the asset. For tables, this is generally a project or a business unit. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project1, bizUnit1</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>The target asset.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public AddRegisterLineageRequestAddRegisterLineageCommandTarget Target { get; set; }
            public class AddRegisterLineageRequestAddRegisterLineageCommandTarget : TeaModel {
                /// <summary>
                /// <para>The catalog of the asset. For tables, the catalog of compute source tables or logical tables is uniformly set to Dataphin. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataphin</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The environment to which the asset belongs. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV, PROD</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The extended properties.</para>
                /// </summary>
                [NameInMap("ExtProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtProperties { get; set; }

                /// <summary>
                /// <para>The GUID of the asset. This parameter is required when ReferenceType is set to BY_GUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.300000001.project1.table1</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The subtype of the asset. Specify this parameter only when MetadataType is set to TABLE and ReferenceType is not set to BY_GUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHYSICAL_TABLE, PHYSICAL_VIEW, PHYSICAL_MATERIALIZED_VIEW, DATASOURCE_TABLE, DATASOURCE_VIEW, DATASOURCE_MATERIALIZED_VIEW, DIM_NORMAL, DIM_LEVEL, DIM_ENUM, DIM_VIRTUAL, FACT_EVENT, FACT_PROCESS, FACT_SNAPSHOT, SUM_BIZ_UNIT</para>
                /// </summary>
                [NameInMap("MetadataSubType")]
                [Validation(Required=false)]
                public string MetadataSubType { get; set; }

                /// <summary>
                /// <para>The Asset Type. Specify this parameter as needed.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("MetadataType")]
                [Validation(Required=false)]
                public string MetadataType { get; set; }

                /// <summary>
                /// <para>The name of the asset. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The reference data type of the asset. Valid values: BY_GUID and BY_PROPERTY.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BY_GUID, BY_PROPERTY</para>
                /// </summary>
                [NameInMap("ReferenceType")]
                [Validation(Required=false)]
                public string ReferenceType { get; set; }

                /// <summary>
                /// <para>The schema of the asset. For tables, this is generally a project or a business unit. This property is used to identify the corresponding asset based on properties when ReferenceType is set to BY_PROPERTY. If ReferenceType is set to BY_GUID, this property is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project1, bizUnit1</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001234</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The current user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300004567</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
