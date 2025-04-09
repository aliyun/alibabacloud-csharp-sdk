// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public List<string> ExpiredTime { get; set; }

        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public List<ModifyRCInstanceChargeTypeResponseBodyFeeOfInstances> FeeOfInstances { get; set; }
        public class ModifyRCInstanceChargeTypeResponseBodyFeeOfInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Fee")]
            [Validation(Required=false)]
            public string Fee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2133400000****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6EF82B07-28D2-48D1-B5D6-7E78FED277C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
