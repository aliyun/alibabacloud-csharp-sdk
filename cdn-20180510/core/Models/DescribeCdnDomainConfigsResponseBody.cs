// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the domain name.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public DescribeCdnDomainConfigsResponseBodyDomainConfigs DomainConfigs { get; set; }
        public class DescribeCdnDomainConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfig> DomainConfig { get; set; }
            public class DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6295</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// <para>The configuration of each feature.</para>
                /// </summary>
                [NameInMap("FunctionArgs")]
                [Validation(Required=false)]
                public DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs FunctionArgs { get; set; }
                public class DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgs : TeaModel {
                    [NameInMap("FunctionArg")]
                    [Validation(Required=false)]
                    public List<DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg> FunctionArg { get; set; }
                    public class DescribeCdnDomainConfigsResponseBodyDomainConfigsDomainConfigFunctionArgsFunctionArg : TeaModel {
                        /// <summary>
                        /// <para>The parameter name, which is the configuration item of <b>functionName</b>. You can configure multiple configuration items.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>auth_type</para>
                        /// </summary>
                        [NameInMap("ArgName")]
                        [Validation(Required=false)]
                        public string ArgName { get; set; }

                        /// <summary>
                        /// <para>The parameter value, which is the value of the configuration item of <b>functionName</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>req_auth</para>
                        /// </summary>
                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliauth</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The ID of the rule condition. This parameter is optional.</para>
                /// <para>To create a rule condition, you can configure the <b>condition</b> feature that is described in the <a href="https://help.aliyun.com/document_detail/388460.html">Parameters for configuring features for domain names</a> topic. A rule condition can identify parameters that are included in requests and filter requests based on the identified parameters. Each rule condition has a <a href="https://help.aliyun.com/document_detail/388994.html">ConfigId</a>. You can use ConfigId as ParentId that is referenced by other features. This way, you can combine rule conditions and features for flexible configurations.</para>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/90915.html">BatchSetCdnDomainConfig</a> or ParentId configuration example in this topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>222728944812032</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The status of the configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b></description></item>
                /// <item><description><b>testing</b></description></item>
                /// <item><description><b>failed</b></description></item>
                /// <item><description><b>configuring</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C80705BF-0F76-41FA-BAD1-5B59296A4E59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
