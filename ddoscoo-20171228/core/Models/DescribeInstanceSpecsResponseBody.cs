// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("BandwidthMbps")]
            [Validation(Required=false)]
            public int? BandwidthMbps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BaseBandwidth")]
            [Validation(Required=false)]
            public int? BaseBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DomainLimit")]
            [Validation(Required=false)]
            public int? DomainLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public int? ElasticBandwidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public string FunctionVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-XXXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PortLimit")]
            [Validation(Required=false)]
            public int? PortLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("QpsLimit")]
            [Validation(Required=false)]
            public int? QpsLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SiteLimit")]
            [Validation(Required=false)]
            public int? SiteLimit { get; set; }

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
