// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainStagingConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of accelerated domain names returned.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainStagingConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeDcdnDomainStagingConfigResponseBodyDomainConfigs : TeaModel {
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
            /// <para>The following table describes the features.</para>
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeDcdnDomainStagingConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                /// <summary>
                /// <para>The name of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auth_type</para>
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// <para>The value of the configuration.</para>
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
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The configuration is successful.</description></item>
            /// <item><description>testing: The configuration is under testing.</description></item>
            /// <item><description>failed: The task failed.</description></item>
            /// <item><description>configuring: The feature is being configured.</description></item>
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
