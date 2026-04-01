// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceTypeFamiliesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance families.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamilies : TeaModel {
            /// <summary>
            /// <para>The instance family.</para>
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily> InstanceTypeFamily { get; set; }
            public class DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily : TeaModel {
                /// <summary>
                /// <para>The description of the instance family.</para>
                /// </summary>
                [NameInMap("InstanceTypeFamilyDesc")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyDesc { get; set; }

                /// <summary>
                /// <para>The ID of the instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x.6cm</para>
                /// </summary>
                [NameInMap("InstanceTypeFamilyId")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2911788-25E8-42E5-A3A3-1B38D263F01E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
