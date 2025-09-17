// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class PushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-01-11 10:31:00</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("MeteringData")]
        [Validation(Required=false)]
        public List<PushMeteringDataRequestMeteringData> MeteringData { get; set; }
        public class PushMeteringDataRequestMeteringData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1666854480406</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gtm-cn-20p314k5h05</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("MeteringAssist")]
            [Validation(Required=false)]
            public string MeteringAssist { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;VirtualCpu&quot;:10}</para>
            /// </summary>
            [NameInMap("MeteringEntity")]
            [Validation(Required=false)]
            public string MeteringEntity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORDER20231001</para>
            /// </summary>
            [NameInMap("PushOrderBizId")]
            [Validation(Required=false)]
            public string PushOrderBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1662284820000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
