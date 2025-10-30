// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddRegisterLineageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddRegisterLineageCommand")]
        [Validation(Required=false)]
        public AddRegisterLineageRequestAddRegisterLineageCommand AddRegisterLineageCommand { get; set; }
        public class AddRegisterLineageRequestAddRegisterLineageCommand : TeaModel {
            [NameInMap("CheckAssetExist")]
            [Validation(Required=false)]
            public bool? CheckAssetExist { get; set; }

            [NameInMap("DetailedLineages")]
            [Validation(Required=false)]
            public List<AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineages> DetailedLineages { get; set; }
            public class AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineages : TeaModel {
                [NameInMap("IsDirect")]
                [Validation(Required=false)]
                public bool? IsDirect { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesSource Source { get; set; }
                public class AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesSource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dataphin</para>
                    /// </summary>
                    [NameInMap("Catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DEV, PROD</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    [NameInMap("ExtProperties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtProperties { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1.column1</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>COLUMN</para>
                    /// </summary>
                    [NameInMap("MetadataType")]
                    [Validation(Required=false)]
                    public string MetadataType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>column1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1</para>
                    /// </summary>
                    [NameInMap("ParentGuid")]
                    [Validation(Required=false)]
                    public string ParentGuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BY_GUID, BY_PROPERTY</para>
                    /// </summary>
                    [NameInMap("ReferenceType")]
                    [Validation(Required=false)]
                    public string ReferenceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project1, bizUnit1</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesTarget Target { get; set; }
                public class AddRegisterLineageRequestAddRegisterLineageCommandDetailedLineagesTarget : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dataphin</para>
                    /// </summary>
                    [NameInMap("Catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DEV, PROD</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    [NameInMap("ExtProperties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtProperties { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1.column1</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>COLUMN</para>
                    /// </summary>
                    [NameInMap("MetadataType")]
                    [Validation(Required=false)]
                    public string MetadataType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>column1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps.300000001.project1.table1</para>
                    /// </summary>
                    [NameInMap("ParentGuid")]
                    [Validation(Required=false)]
                    public string ParentGuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BY_GUID, BY_PROPERTY</para>
                    /// </summary>
                    [NameInMap("ReferenceType")]
                    [Validation(Required=false)]
                    public string ReferenceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project1, bizUnit1</para>
                    /// </summary>
                    [NameInMap("Schema")]
                    [Validation(Required=false)]
                    public string Schema { get; set; }

                }

            }

            [NameInMap("RelationProperties")]
            [Validation(Required=false)]
            public Dictionary<string, object> RelationProperties { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public AddRegisterLineageRequestAddRegisterLineageCommandSource Source { get; set; }
            public class AddRegisterLineageRequestAddRegisterLineageCommandSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dataphin</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV, PROD</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                [NameInMap("ExtProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtProperties { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps.300000001.project1.table1</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PHYSICAL_TABLE, PHYSICAL_VIEW, PHYSICAL_MATERIALIZED_VIEW, DATASOURCE_TABLE, DATASOURCE_VIEW, DATASOURCE_MATERIALIZED_VIEW, DIM_NORMAL, DIM_LEVEL, DIM_ENUM, DIM_VIRTUAL, FACT_EVENT, FACT_PROCESS, FACT_SNAPSHOT, SUM_BIZ_UNIT</para>
                /// </summary>
                [NameInMap("MetadataSubType")]
                [Validation(Required=false)]
                public string MetadataSubType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("MetadataType")]
                [Validation(Required=false)]
                public string MetadataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BY_GUID, BY_PROPERTY</para>
                /// </summary>
                [NameInMap("ReferenceType")]
                [Validation(Required=false)]
                public string ReferenceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>project1, bizUnit1</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public AddRegisterLineageRequestAddRegisterLineageCommandTarget Target { get; set; }
            public class AddRegisterLineageRequestAddRegisterLineageCommandTarget : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dataphin</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV, PROD</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                [NameInMap("ExtProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtProperties { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps.300000001.project1.table1</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PHYSICAL_TABLE, PHYSICAL_VIEW, PHYSICAL_MATERIALIZED_VIEW, DATASOURCE_TABLE, DATASOURCE_VIEW, DATASOURCE_MATERIALIZED_VIEW, DIM_NORMAL, DIM_LEVEL, DIM_ENUM, DIM_VIRTUAL, FACT_EVENT, FACT_PROCESS, FACT_SNAPSHOT, SUM_BIZ_UNIT</para>
                /// </summary>
                [NameInMap("MetadataSubType")]
                [Validation(Required=false)]
                public string MetadataSubType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("MetadataType")]
                [Validation(Required=false)]
                public string MetadataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BY_GUID, BY_PROPERTY</para>
                /// </summary>
                [NameInMap("ReferenceType")]
                [Validation(Required=false)]
                public string ReferenceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>project1, bizUnit1</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300001234</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300004567</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
