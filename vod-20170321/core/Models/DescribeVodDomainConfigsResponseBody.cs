// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// The value of the parameter.
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeVodDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeVodDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// ## Feature description
                /// 
                /// | Feature | Description |
                /// | ------- | ----------- |
                /// | referer_white_list_set | Specifies the referer whitelist. |
                /// | referer_black_list_set | Specifies the referer blacklist. |
                /// | filetype_based_ttl_set | Specifies the time period after which a file expires. |
                /// | path_based_ttl_set | Specifies the time period after which a directory expires. |
                /// | cc_defense | Configures protection against HTTP flood attacks. |
                /// | oss_auth | Configures authentication for the access to an Object Storage Service (OSS) bucket. |
                /// | ip_black_list_set | Specifies the IP address blacklist. |
                /// | ip_white_list_set | Specifies the IP address whitelist. |
                /// | error_page | Redirects an error page to a specified page. |
                /// | tesla | Optimizes pages to accelerate access. |
                /// | set_req_host_header | Modifies the custom header of back-to-origin requests. |
                /// | set_hashkey_args | Ignores the specified URL parameters. |
                /// | aliauth | Configures Alibaba Cloud authentication. |
                /// | set_resp_header | Specifies a response header. To verify the setting, you can check the response message in a browser. |
                /// | video_seek | Configures video seeking. |
                /// | range | Configures object chunking. |
                /// | gzip | Optimizes pages by using GNU zip (Gzip) compression. |
                /// | https_force | Configures force redirect to HTTPS. |
                /// | http_force | Configures force redirect to HTTP. |
                /// | alivod | Configures ApsaraVideo VOD. |
                /// | forward_scheme | Specifies the origin protocol policy or configures whether to enable adaptive origin fetch. |
                /// | tmd_signature | Specifies the self-defined rules for the rate limit. |
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeVodDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// Queries the configurations of a specified domain name for CDN. You can query the configurations of one or more features at a time.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The operation that you want to perform. Set the value to **DescribeVodDomainConfigs**.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The status of the configuration. Valid values:
        /// 
        /// - **success**
        /// - **testing**
        /// - **failed**
        /// - **configuring**
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
