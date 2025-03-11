// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstanceSwitchAzoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DSSDF-SEWE-23ERW</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the operation.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInstanceSwitchAzoneResponseBodyResult Result { get; set; }
        public class DescribeInstanceSwitchAzoneResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the source azoneId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("OriginAzoneId")]
            [Validation(Required=false)]
            public string OriginAzoneId { get; set; }

            /// <summary>
            /// <para>regionId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the job can be switched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SwitchAble")]
            [Validation(Required=false)]
            public bool? SwitchAble { get; set; }

            /// <summary>
            /// <para>Target azones.</para>
            /// </summary>
            [NameInMap("TargetAzones")]
            [Validation(Required=false)]
            public DescribeInstanceSwitchAzoneResponseBodyResultTargetAzones TargetAzones { get; set; }
            public class DescribeInstanceSwitchAzoneResponseBodyResultTargetAzones : TeaModel {
                [NameInMap("TargetAzone")]
                [Validation(Required=false)]
                public List<string> TargetAzone { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
