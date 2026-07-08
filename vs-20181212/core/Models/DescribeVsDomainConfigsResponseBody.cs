// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>Domain name configurations.</para>
        /// </summary>
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeVsDomainConfigsResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeVsDomainConfigsResponseBodyDomainConfigs : TeaModel {
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
            /// <para>Each function.</para>
            /// </summary>
            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeVsDomainConfigsResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeVsDomainConfigsResponseBodyDomainConfigsFunctionArgs : TeaModel {
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
                /// <para>The argument value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>req_auth</para>
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            /// <summary>
            /// <para>The function name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliauth</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>Status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>success</para>
            /// </description></item>
            /// <item><description><para>testing</para>
            /// </description></item>
            /// <item><description><para>failed</para>
            /// </description></item>
            /// <item><description><para>configuring</para>
            /// </description></item>
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
        /// <para>D94D0E1E-E71B-562D-8C18-969BB3653FBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
