// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class PullServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        public List<PullServicesResponseBodyData> Data { get; set; }
        public class PullServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The namespace alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("NamespaceShowName")]
            [Validation(Required=false)]
            public string NamespaceShowName { get; set; }

            /// <summary>
            /// <para>The list of services.</para>
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public List<PullServicesResponseBodyDataServices> Services { get; set; }
            public class PullServicesResponseBodyDataServices : TeaModel {
                /// <summary>
                /// <para>The group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The SAE application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
                /// </summary>
                [NameInMap("SaeAppId")]
                [Validation(Required=false)]
                public string SaeAppId { get; set; }

                /// <summary>
                /// <para>The source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The list of associated service source IDs.</para>
                /// </summary>
                [NameInMap("SourceIdList")]
                [Validation(Required=false)]
                public List<long?> SourceIdList { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

        }

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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation. Action: mse:PullServices, Resource: acs:mse:cn-shenzhen:1228932054837788:*</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC0A99B9-8BA3-5FE3-8FE7-D7C719CF7BD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
