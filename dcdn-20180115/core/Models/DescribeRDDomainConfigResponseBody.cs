// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRDDomainConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the domain name.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeRDDomainConfigResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeRDDomainConfigResponseBodyDomainConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6295</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The configurations of the features.</para>
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeRDDomainConfigResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeRDDomainConfigResponseBodyDomainConfigsFunctionArgs : TeaModel {
                /// <summary>
                /// <para>The name of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>source_group_name</para>
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// <para>The value of the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set_req_host_header</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The ID of the advanced condition configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
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
