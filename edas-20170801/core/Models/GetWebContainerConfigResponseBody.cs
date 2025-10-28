// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetWebContainerConfigResponseBody : TeaModel {
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
        /// <para>4823-bhjf-23u4-eiufh</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Tomcat configurations of the application.</para>
        /// </summary>
        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public GetWebContainerConfigResponseBodyWebContainerConfig WebContainerConfig { get; set; }
        public class GetWebContainerConfigResponseBodyWebContainerConfig : TeaModel {
            /// <summary>
            /// <para>The type of the context path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("ContextInputType")]
            [Validation(Required=false)]
            public string ContextInputType { get; set; }

            /// <summary>
            /// <para>The context path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT</para>
            /// </summary>
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            /// <summary>
            /// <para>The HTTP service port.</para>
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
            /// <para>500</para>
            /// </summary>
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }

            /// <summary>
            /// <para>The content of the server.xml file customized by using advanced configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&lt;Server port=*****</para>
            /// </summary>
            [NameInMap("ServerXml")]
            [Validation(Required=false)]
            public string ServerXml { get; set; }

            /// <summary>
            /// <para>The URI encoding scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ISO-8859-1</para>
            /// </summary>
            [NameInMap("UriEncoding")]
            [Validation(Required=false)]
            public string UriEncoding { get; set; }

            /// <summary>
            /// <para>Indicates whether advanced configurations are used to customize the server.xml file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseAdvancedServerXml")]
            [Validation(Required=false)]
            public bool? UseAdvancedServerXml { get; set; }

            /// <summary>
            /// <para>Indicates whether the encoding scheme specified in the request body is used for uniform resource identifier (URI) query parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

            /// <summary>
            /// <para>Indicates whether the default configurations are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseDefaultConfig")]
            [Validation(Required=false)]
            public bool? UseDefaultConfig { get; set; }

        }

    }

}
