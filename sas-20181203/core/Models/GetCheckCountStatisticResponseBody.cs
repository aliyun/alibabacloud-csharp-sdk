// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckCountStatisticResponseBody : TeaModel {
        [NameInMap("CheckCountStatisticDTO")]
        [Validation(Required=false)]
        public GetCheckCountStatisticResponseBodyCheckCountStatisticDTO CheckCountStatisticDTO { get; set; }
        public class GetCheckCountStatisticResponseBodyCheckCountStatisticDTO : TeaModel {
            [NameInMap("CheckCountStatisticItems")]
            [Validation(Required=false)]
            public List<GetCheckCountStatisticResponseBodyCheckCountStatisticDTOCheckCountStatisticItems> CheckCountStatisticItems { get; set; }
            public class GetCheckCountStatisticResponseBodyCheckCountStatisticDTOCheckCountStatisticItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>i-wz9bpxyu6t74qn9g****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>launch-advisor-2021****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InstanceSubType")]
                [Validation(Required=false)]
                public int? InstanceSubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INSTANCE</para>
                /// </summary>
                [NameInMap("InstanceSubTypeName")]
                [Validation(Required=false)]
                public string InstanceSubTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public int? InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("StatisticType")]
            [Validation(Required=false)]
            public string StatisticType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20456DD5-5CBF-5015-9173-12CA4246B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
