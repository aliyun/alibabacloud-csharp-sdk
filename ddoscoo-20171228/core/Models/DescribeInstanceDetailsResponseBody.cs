// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceDetailsResponseBody : TeaModel {
        [NameInMap("InstanceDetails")]
        [Validation(Required=false)]
        public List<DescribeInstanceDetailsResponseBodyInstanceDetails> InstanceDetails { get; set; }
        public class DescribeInstanceDetailsResponseBodyInstanceDetails : TeaModel {
            [NameInMap("EipInfoList")]
            [Validation(Required=false)]
            public List<DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfoList> EipInfoList { get; set; }
            public class DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-XXXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>coop-line-001</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
