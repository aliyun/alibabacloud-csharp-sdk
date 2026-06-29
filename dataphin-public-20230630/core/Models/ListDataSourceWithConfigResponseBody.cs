// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataSourceWithConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataSourceWithConfigResponseBodyPageResult PageResult { get; set; }
        public class ListDataSourceWithConfigResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>Paginated list</para>
            /// </summary>
            [NameInMap("DataSourceList")]
            [Validation(Required=false)]
            public List<ListDataSourceWithConfigResponseBodyPageResultDataSourceList> DataSourceList { get; set; }
            public class ListDataSourceWithConfigResponseBodyPageResultDataSourceList : TeaModel {
                /// <summary>
                /// <para>Development environment data source</para>
                /// </summary>
                [NameInMap("DevDataSourceInfo")]
                [Validation(Required=false)]
                public ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfo DevDataSourceInfo { get; set; }
                public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfo : TeaModel {
                    /// <summary>
                    /// <para>Connection configuration items</para>
                    /// </summary>
                    [NameInMap("ConfigItemList")]
                    [Validation(Required=false)]
                    public List<ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfoConfigItemList> ConfigItemList { get; set; }
                    public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfoConfigItemList : TeaModel {
                        /// <summary>
                        /// <para>Configuration item ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Configuration item value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Creation time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710209552704</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Creator ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <para>Creator name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    /// <summary>
                    /// <para>Description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx 项目</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Environment of the data source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Data source ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12313123131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Modification time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710209552704</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>Data source name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Owner ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>Owner name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>Data source scope</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    /// <summary>
                    /// <para>Data source type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Production environment data source</para>
                /// </summary>
                [NameInMap("ProdDataSourceInfo")]
                [Validation(Required=false)]
                public ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfo ProdDataSourceInfo { get; set; }
                public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfo : TeaModel {
                    /// <summary>
                    /// <para>Connection configuration items</para>
                    /// </summary>
                    [NameInMap("ConfigItemList")]
                    [Validation(Required=false)]
                    public List<ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfoConfigItemList> ConfigItemList { get; set; }
                    public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfoConfigItemList : TeaModel {
                        /// <summary>
                        /// <para>Configuration item ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Configuration item value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Creation time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1708303959000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Creator ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <para>Creator name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    /// <summary>
                    /// <para>Description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx 测试</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Environment of the data source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PROD</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Data source ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000028799</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Modification time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1708303959000</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>Data source name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Owner ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>Owner name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>Data source scope</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    /// <summary>
                    /// <para>Data source type</para>
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
            /// <para>Total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>39</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
