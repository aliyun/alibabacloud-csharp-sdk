// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration information.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public GetNacosConfigResponseBodyConfiguration Configuration { get; set; }
        public class GetNacosConfigResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// <para>Application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>List of IPs for Beta release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX，2.2.XX.XX</para>
            /// </summary>
            [NameInMap("BetaIps")]
            [Validation(Required=false)]
            public string BetaIps { get; set; }

            /// <summary>
            /// <para>Configuration content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log.level=error</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log.yaml</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Configuration description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For testing</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>Encrypted key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("EncryptedDataKey")]
            [Validation(Required=false)]
            public string EncryptedDataKey { get; set; }

            /// <summary>
            /// <para>Current gray version information</para>
            /// </summary>
            [NameInMap("GrayVersions")]
            [Validation(Required=false)]
            public List<GetNacosConfigResponseBodyConfigurationGrayVersions> GrayVersions { get; set; }
            public class GetNacosConfigResponseBodyConfigurationGrayVersions : TeaModel {
                /// <summary>
                /// <para>Gray version name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The priority of the current gray rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>Rules of the current gray version</para>
                /// 
                /// <b>Example:</b>
                /// <para>a=b</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>Gray type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beta</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Configuration group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>Message digest of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123rfsdf3</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>Tags of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>Format of the configuration content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4EAB48C-BB4B-5B8D-B33B-35D69606C5AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
