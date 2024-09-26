// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DataService Studio API on which the test is performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12343</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// <para>The data of the request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("BodyContent")]
        [Validation(Required=false)]
        public string BodyContent { get; set; }

        /// <summary>
        /// <para>The request parameters that are contained in the request body.</para>
        /// </summary>
        [NameInMap("BodyParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestBodyParams> BodyParams { get; set; }
        public class TestDataServiceApiRequestBodyParams : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        /// <summary>
        /// <para>The request parameters that are contained in the request header.</para>
        /// </summary>
        [NameInMap("HeadParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestHeadParams> HeadParams { get; set; }
        public class TestDataServiceApiRequestHeadParams : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>requestId</para>
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        /// <summary>
        /// <para>The request parameters that are contained in the request path.</para>
        /// </summary>
        [NameInMap("PathParams")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestPathParams> PathParams { get; set; }
        public class TestDataServiceApiRequestPathParams : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>path1</para>
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

        /// <summary>
        /// <para>The request parameters that are contained in the query.</para>
        /// </summary>
        [NameInMap("QueryParam")]
        [Validation(Required=false)]
        public List<TestDataServiceApiRequestQueryParam> QueryParam { get; set; }
        public class TestDataServiceApiRequestQueryParam : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("ParamKey")]
            [Validation(Required=false)]
            public string ParamKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

        }

    }

}
