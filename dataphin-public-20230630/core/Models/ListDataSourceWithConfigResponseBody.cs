// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataSourceWithConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataSourceWithConfigResponseBodyPageResult PageResult { get; set; }
        public class ListDataSourceWithConfigResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paginated list.</para>
            /// </summary>
            [NameInMap("DataSourceList")]
            [Validation(Required=false)]
            public List<ListDataSourceWithConfigResponseBodyPageResultDataSourceList> DataSourceList { get; set; }
            public class ListDataSourceWithConfigResponseBodyPageResultDataSourceList : TeaModel {
                /// <summary>
                /// <para>The data source in the development environment.</para>
                /// </summary>
                [NameInMap("DevDataSourceInfo")]
                [Validation(Required=false)]
                public ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfo DevDataSourceInfo { get; set; }
                public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The connection configuration items.</para>
                    /// </summary>
                    [NameInMap("ConfigItemList")]
                    [Validation(Required=false)]
                    public List<ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfoConfigItemList> ConfigItemList { get; set; }
                    public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListDevDataSourceInfoConfigItemList : TeaModel {
                        /// <summary>
                        /// <para>The ID of the configuration item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the configuration item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710209552704</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the creator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <para>The name of the creator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhang San</para>
                    /// </summary>
                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx project</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The environment to which the data source belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The ID of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12313123131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1710209552704</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The name of the owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhang San</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>The usage scope of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    /// <summary>
                    /// <para>The data source types.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The data source in the production environment.</para>
                /// </summary>
                [NameInMap("ProdDataSourceInfo")]
                [Validation(Required=false)]
                public ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfo ProdDataSourceInfo { get; set; }
                public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The connection configuration items.</para>
                    /// </summary>
                    [NameInMap("ConfigItemList")]
                    [Validation(Required=false)]
                    public List<ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfoConfigItemList> ConfigItemList { get; set; }
                    public class ListDataSourceWithConfigResponseBodyPageResultDataSourceListProdDataSourceInfoConfigItemList : TeaModel {
                        /// <summary>
                        /// <para>The ID of the configuration item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>param1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the configuration item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1708303959000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the creator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <para>The name of the creator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhang San</para>
                    /// </summary>
                    [NameInMap("CreatorName")]
                    [Validation(Required=false)]
                    public string CreatorName { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The environment to which the data source belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PROD</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The ID of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000028799</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1708303959000</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>212211111</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The name of the owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhang San</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>The usage scope of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    /// <summary>
                    /// <para>The data source types.</para>
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
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
