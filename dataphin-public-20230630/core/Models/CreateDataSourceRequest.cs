// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDataSourceRequest : TeaModel {
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDataSourceRequestCreateCommand CreateCommand { get; set; }
        public class CreateDataSourceRequestCreateCommand : TeaModel {
            [NameInMap("DevDataSourceCreate")]
            [Validation(Required=false)]
            public CreateDataSourceRequestCreateCommandDevDataSourceCreate DevDataSourceCreate { get; set; }
            public class CreateDataSourceRequestCreateCommandDevDataSourceCreate : TeaModel {
                /// <summary>
                /// <para>数据源创建结构体</para>
                /// </summary>
                [NameInMap("DataSourceCreate")]
                [Validation(Required=false)]
                public CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreate DataSourceCreate { get; set; }
                public class CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreate : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CheckActivity")]
                    [Validation(Required=false)]
                    public bool? CheckActivity { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ConfigItemList")]
                    [Validation(Required=false)]
                    public List<CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreateConfigItemList> ConfigItemList { get; set; }
                    public class CreateDataSourceRequestCreateCommandDevDataSourceCreateDataSourceCreateConfigItemList : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>datasource for xxx in dev</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dp_test_dev</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1011</para>
                /// </summary>
                [NameInMap("ProdDataSourceId")]
                [Validation(Required=false)]
                public long? ProdDataSourceId { get; set; }

            }

            /// <summary>
            /// <para>数据源创建结构体</para>
            /// </summary>
            [NameInMap("ProdDataSourceCreate")]
            [Validation(Required=false)]
            public CreateDataSourceRequestCreateCommandProdDataSourceCreate ProdDataSourceCreate { get; set; }
            public class CreateDataSourceRequestCreateCommandProdDataSourceCreate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CheckActivity")]
                [Validation(Required=false)]
                public bool? CheckActivity { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConfigItemList")]
                [Validation(Required=false)]
                public List<CreateDataSourceRequestCreateCommandProdDataSourceCreateConfigItemList> ConfigItemList { get; set; }
                public class CreateDataSourceRequestCreateCommandProdDataSourceCreateConfigItemList : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>datasource for xx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dp_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAX_COMPUTE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
