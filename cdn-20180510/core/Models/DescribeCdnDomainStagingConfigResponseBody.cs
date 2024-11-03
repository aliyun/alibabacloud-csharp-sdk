// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainStagingConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name configurations.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeCdnDomainStagingConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeCdnDomainStagingConfigResponseBodyDomainConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6xx5</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>The description of each feature.</para>
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeCdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeCdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                /// <summary>
                /// <para>The configuration name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auth_type</para>
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// <para>The configuration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>req_auth</para>
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            /// <summary>
            /// <para>The feature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliauth</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The rule condition ID. This parameter is optional. To create a rule condition, you can configure the <b>condition</b> feature that is described in the <a href="https://help.aliyun.com/document_detail/388460.html">Parameters for configuring features for domain names</a> topic. A rule condition can identify parameters that are included in requests and filter requests based on the identified parameters. Each rule condition has a <a href="https://help.aliyun.com/document_detail/388994.html">ConfigId</a>. You can reference ConfigId instead of ParentId in other features. This way, you can combine rule conditions and features for flexible configurations. For more information, see <a href="https://help.aliyun.com/document_detail/90915.html">BatchSetCdnDomainConfig</a> or ParentId configuration example in this topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222728944812032</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The configuration status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>testing</b></description></item>
            /// <item><description><b>configuring</b></description></item>
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C80705BF-0F76-41FA-BAD1-5B59296A4E59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
