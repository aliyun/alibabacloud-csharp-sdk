// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRegionBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the location blacklist.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeNetworkRegionBlockResponseBodyConfig Config { get; set; }
        public class DescribeNetworkRegionBlockResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The list of blocked region codes outside China.</para>
            /// </summary>
            [NameInMap("Countries")]
            [Validation(Required=false)]
            public List<long?> Countries { get; set; }

            /// <summary>
            /// <para>The list of blocked region codes in China.</para>
            /// </summary>
            [NameInMap("Provinces")]
            [Validation(Required=false)]
            public List<long?> Provinces { get; set; }

            /// <summary>
            /// <para>The status of the location blacklist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RegionBlockSwitch")]
            [Validation(Required=false)]
            public string RegionBlockSwitch { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
