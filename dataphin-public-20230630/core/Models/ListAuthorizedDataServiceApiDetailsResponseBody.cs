// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAuthorizedDataServiceApiDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
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
        /// <para>非法入参</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is a unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListAuthorizedDataServiceApiDetailsResponseBodyResult Result { get; set; }
        public class ListAuthorizedDataServiceApiDetailsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of authorized API details.</para>
            /// </summary>
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
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GetData</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>The permission type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>使用权限</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The list of fields authorized for the API in the development environment.</para>
                /// </summary>
                [NameInMap("AuthorizedDevReturnParameters")]
                [Validation(Required=false)]
                public List<ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedDevReturnParameters> AuthorizedDevReturnParameters { get; set; }
                public class ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedDevReturnParameters : TeaModel {
                    /// <summary>
                    /// <para>The example value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example1</para>
                    /// </summary>
                    [NameInMap("ExampleValue")]
                    [Validation(Required=false)]
                    public string ExampleValue { get; set; }

                    /// <summary>
                    /// <para>The field authorization status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IsAuthorized")]
                    [Validation(Required=false)]
                    public int? IsAuthorized { get; set; }

                    /// <summary>
                    /// <para>The parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ParameterDataType")]
                    [Validation(Required=false)]
                    public int? ParameterDataType { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>description1</para>
                    /// </summary>
                    [NameInMap("ParameterDescription")]
                    [Validation(Required=false)]
                    public string ParameterDescription { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                }

                /// <summary>
                /// <para>The list of fields authorized for the API in the production environment.</para>
                /// </summary>
                [NameInMap("AuthorizedProdReturnParameters")]
                [Validation(Required=false)]
                public List<ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedProdReturnParameters> AuthorizedProdReturnParameters { get; set; }
                public class ListAuthorizedDataServiceApiDetailsResponseBodyResultDataAuthorizedProdReturnParameters : TeaModel {
                    /// <summary>
                    /// <para>The example value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example1</para>
                    /// </summary>
                    [NameInMap("ExampleValue")]
                    [Validation(Required=false)]
                    public string ExampleValue { get; set; }

                    /// <summary>
                    /// <para>The field authorization status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IsAuthorized")]
                    [Validation(Required=false)]
                    public int? IsAuthorized { get; set; }

                    /// <summary>
                    /// <para>The parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ParameterDataType")]
                    [Validation(Required=false)]
                    public int? ParameterDataType { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>description1</para>
                    /// </summary>
                    [NameInMap("ParameterDescription")]
                    [Validation(Required=false)]
                    public string ParameterDescription { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>param1</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                }

                /// <summary>
                /// <para>The API description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The validity period of the API permission in the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2035-12-31</para>
                /// </summary>
                [NameInMap("DevAuthPeriod")]
                [Validation(Required=false)]
                public string DevAuthPeriod { get; set; }

                /// <summary>
                /// <para>The validity period of the API permission in the production environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2035-12-31</para>
                /// </summary>
                [NameInMap("ProdAuthPeriod")]
                [Validation(Required=false)]
                public string ProdAuthPeriod { get; set; }

                /// <summary>
                /// <para>The data service project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
