// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthConnectBlackResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request is successful. Other status codes indicate that the request failed. For a list of error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthConnectBlackResponseBodyData Data { get; set; }
        public class QueryCustomAuthConnectBlackResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAZ0cM0HTqLXvgm7oMHWXcvc=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The returned results.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthConnectBlackResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthConnectBlackResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The client ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_TEST@@@test</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>Indicates whether to allow or deny access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALLOW</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The authorized permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONNECT</para>
                /// </summary>
                [NameInMap("PermitAction")]
                [Validation(Required=false)]
                public string PermitAction { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
