// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisFactorDistributionStatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisFactorDistributionStatResponseBodyStatList> StatList { get; set; }
        public class DescribeFaultDiagnosisFactorDistributionStatResponseBodyStatList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9239</para>
            /// </summary>
            [NameInMap("UserRatio")]
            [Validation(Required=false)]
            public float? UserRatio { get; set; }

        }

    }

}
