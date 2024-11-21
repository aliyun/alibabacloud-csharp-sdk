// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public GetNacosConfigResponseBodyConfiguration Configuration { get; set; }
        public class GetNacosConfigResponseBodyConfiguration : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The list of IP addresses where the beta release of the configuration is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX,2.2.XX.XX</para>
            /// </summary>
            [NameInMap("BetaIps")]
            [Validation(Required=false)]
            public string BetaIps { get; set; }

            /// <summary>
            /// <para>The content of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log.level=error</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log.yaml</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The description of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For testing</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The encryption key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("EncryptedDataKey")]
            [Validation(Required=false)]
            public string EncryptedDataKey { get; set; }

            [NameInMap("GrayVersions")]
            [Validation(Required=false)]
            public List<GetNacosConfigResponseBodyConfigurationGrayVersions> GrayVersions { get; set; }
            public class GetNacosConfigResponseBodyConfigurationGrayVersions : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The message digest of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123rfsdf3</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The tags of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The format of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
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
        /// <para>B4EAB48C-BB4B-5B8D-B33B-35D69606C5AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
