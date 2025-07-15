// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainStagingConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The feature configurations of the accelerated domain name.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeLiveDomainStagingConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeLiveDomainStagingConfigResponseBodyDomainConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6295</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>The configurations of the feature.</para>
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainStagingConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeLiveDomainStagingConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auth_type</para>
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// <para>The configured value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>req_auth</para>
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

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
            /// <para>The configuration status. Valid values:</para>
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
