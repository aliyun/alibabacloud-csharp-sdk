// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeChargeModuleResponseBody : TeaModel {
        [NameInMap("ChargeModules")]
        [Validation(Required=false)]
        public List<DescribeChargeModuleResponseBodyChargeModules> ChargeModules { get; set; }
        public class DescribeChargeModuleResponseBodyChargeModules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL_PRICE</para>
            /// </summary>
            [NameInMap("ChargeMode")]
            [Validation(Required=false)]
            public string ChargeMode { get; set; }

            [NameInMap("ChargeModeDetails")]
            [Validation(Required=false)]
            public List<string> ChargeModeDetails { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>domainCount</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("PeriodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("UsageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsageUnitFactor")]
            [Validation(Required=false)]
            public int? UsageUnitFactor { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
