// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeResourceGroupSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10226189-4391-5B10-97AF-5CA5XXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried specifications.</para>
        /// </summary>
        [NameInMap("Specs")]
        [Validation(Required=false)]
        public List<DescribeResourceGroupSpecResponseBodySpecs> Specs { get; set; }
        public class DescribeResourceGroupSpecResponseBodySpecs : TeaModel {
            /// <summary>
            /// <para>The allocation units supported by this specification.</para>
            /// </summary>
            [NameInMap("AllocateUnits")]
            [Validation(Required=false)]
            public List<string> AllocateUnits { get; set; }

            /// <summary>
            /// <para>The maximum number of resource groups that can be used with this specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxQuantity")]
            [Validation(Required=false)]
            public int? MaxQuantity { get; set; }

            /// <summary>
            /// <para>The name of the specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlarge</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GPU</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
