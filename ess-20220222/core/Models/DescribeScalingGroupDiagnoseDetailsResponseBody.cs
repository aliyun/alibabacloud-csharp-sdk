// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupDiagnoseDetailsResponseBody : TeaModel {
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeScalingGroupDiagnoseDetailsResponseBodyDetails> Details { get; set; }
        public class DescribeScalingGroupDiagnoseDetailsResponseBodyDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SecurityGroup</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AccountArrearage</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-280ih****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>688B18B8-FB1E-42EB-A1ED-7F55B090****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
