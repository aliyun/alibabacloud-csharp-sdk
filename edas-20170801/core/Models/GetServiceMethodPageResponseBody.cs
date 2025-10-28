// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceMethodPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceMethodPageResponseBodyData Data { get; set; }
        public class GetServiceMethodPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The data about the method.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetServiceMethodPageResponseBodyDataResult> Result { get; set; }
            public class GetServiceMethodPageResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.aliware.edas.EchoController</para>
                /// </summary>
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                /// <summary>
                /// <para>The name of the method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The details of the method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                /// <summary>
                /// <para>The definition of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;description&quot;:&quot;&quot;,&quot;name&quot;:&quot;arg0&quot;,&quot;type&quot;:&quot;java.lang.String&quot;}]</para>
                /// </summary>
                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public string ParameterDefinitions { get; set; }

                /// <summary>
                /// <para>The details of the parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public string ParameterDetails { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo</para>
                /// </summary>
                [NameInMap("ParameterNames")]
                [Validation(Required=false)]
                public string ParameterNames { get; set; }

                /// <summary>
                /// <para>The data type of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public string ParameterTypes { get; set; }

                /// <summary>
                /// <para>The method path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/consumer/alive</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public string Paths { get; set; }

                /// <summary>
                /// <para>The request method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public string RequestMethods { get; set; }

                /// <summary>
                /// <para>The return value.</para>
                /// </summary>
                [NameInMap("ReturnDefinition")]
                [Validation(Required=false)]
                public GetServiceMethodPageResponseBodyDataResultReturnDefinition ReturnDefinition { get; set; }
                public class GetServiceMethodPageResponseBodyDataResultReturnDefinition : TeaModel {
                    /// <summary>
                    /// <para>The ID of the return value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The data format of the response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>java.lang.String</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The details of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                /// <summary>
                /// <para>The data format of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDC0C0FE-D63B-4FC8-<b><b>-4081C57E</b></b></para>
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
