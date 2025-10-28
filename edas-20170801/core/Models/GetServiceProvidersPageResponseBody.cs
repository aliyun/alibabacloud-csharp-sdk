// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceProvidersPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceProvidersPageResponseBodyData Data { get; set; }
        public class GetServiceProvidersPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data array returned.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceProvidersPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceProvidersPageResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The remarks of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.178.XX.XX</para>
                /// </summary>
                [NameInMap("Iannotations")]
                [Validation(Required=false)]
                public string Iannotations { get; set; }

                /// <summary>
                /// <para>The IP address of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.20.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The port number of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The serialization type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hessian2</para>
                /// </summary>
                [NameInMap("SerializeType")]
                [Validation(Required=false)]
                public string SerializeType { get; set; }

                /// <summary>
                /// <para>The service timeout period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
