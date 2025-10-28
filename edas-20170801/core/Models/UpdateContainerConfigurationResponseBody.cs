// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateContainerConfigurationResponseBody : TeaModel {
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
        /// <para>The configuration of the Tomcat container.</para>
        /// </summary>
        [NameInMap("ContainerConfiguration")]
        [Validation(Required=false)]
        public UpdateContainerConfigurationResponseBodyContainerConfiguration ContainerConfiguration { get; set; }
        public class UpdateContainerConfigurationResponseBodyContainerConfiguration : TeaModel {
            /// <summary>
            /// <para>The context path of the Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            /// <summary>
            /// <para>The application port number for the Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// <para>The maximum number of threads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }

            /// <summary>
            /// <para>The URI encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ISO-8859-1</para>
            /// </summary>
            [NameInMap("URIEncoding")]
            [Validation(Required=false)]
            public string URIEncoding { get; set; }

            /// <summary>
            /// <para>Indicates whether useBodyEncodingForURI is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

        }

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
        /// <para>D16979DC-4D42-***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
