// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainConfigsResponseBody : TeaModel {
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeVsDomainConfigsResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeVsDomainConfigsResponseBodyDomainConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6295</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<DescribeVsDomainConfigsResponseBodyDomainConfigsFunctionArgs> FunctionArgs { get; set; }
            public class DescribeVsDomainConfigsResponseBodyDomainConfigsFunctionArgs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>auth_type</para>
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>req_auth</para>
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliauth</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D94D0E1E-E71B-562D-8C18-969BB3653FBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
