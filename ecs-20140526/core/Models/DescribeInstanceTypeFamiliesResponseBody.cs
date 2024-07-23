// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypeFamiliesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance families.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamilies : TeaModel {
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily> InstanceTypeFamily { get; set; }
            public class DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily : TeaModel {
                /// <summary>
                /// <para>The generation of the instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-5</para>
                /// </summary>
                [NameInMap("Generation")]
                [Validation(Required=false)]
                public string Generation { get; set; }

                /// <summary>
                /// <para>The ID of the instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6</para>
                /// </summary>
                [NameInMap("InstanceTypeFamilyId")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
