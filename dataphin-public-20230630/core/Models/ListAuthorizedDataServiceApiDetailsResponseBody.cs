// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAuthorizedDataServiceApiDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>非法入参</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListAuthorizedDataServiceApiDetailsResponseBodyResult Result { get; set; }
        public class ListAuthorizedDataServiceApiDetailsResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAuthorizedDataServiceApiDetailsResponseBodyResultData> Data { get; set; }
            public class ListAuthorizedDataServiceApiDetailsResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>API_ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GetData</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>使用权限</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("AuthorizedDevReturnParameters")]
                [Validation(Required=false)]
                public List<ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedDevReturnParameters> AuthorizedDevReturnParameters { get; set; }
                public class ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedDevReturnParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>example1</para>
                    /// </summary>
                    [NameInMap("ExampleValue")]
                    [Validation(Required=false)]
                    public string ExampleValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IsAuthorized")]
                    [Validation(Required=false)]
                    public int? IsAuthorized { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ParameterDataType")]
                    [Validation(Required=false)]
                    public int? ParameterDataType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>description1</para>
                    /// </summary>
                    [NameInMap("ParameterDescription")]
                    [Validation(Required=false)]
                    public string ParameterDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                }

                [NameInMap("AuthorizedProdReturnParameters")]
                [Validation(Required=false)]
                public List<ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedProdReturnParameters> AuthorizedProdReturnParameters { get; set; }
                public class ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedProdReturnParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>example1</para>
                    /// </summary>
                    [NameInMap("ExampleValue")]
                    [Validation(Required=false)]
                    public string ExampleValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IsAuthorized")]
                    [Validation(Required=false)]
                    public int? IsAuthorized { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ParameterDataType")]
                    [Validation(Required=false)]
                    public int? ParameterDataType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>description1</para>
                    /// </summary>
                    [NameInMap("ParameterDescription")]
                    [Validation(Required=false)]
                    public string ParameterDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Description1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2035-12-31</para>
                /// </summary>
                [NameInMap("DevAuthPeriod")]
                [Validation(Required=false)]
                public string DevAuthPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2035-12-31</para>
                /// </summary>
                [NameInMap("ProdAuthPeriod")]
                [Validation(Required=false)]
                public string ProdAuthPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
