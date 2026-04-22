// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsZoneOverviewResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePvtzStatisticsZoneOverviewResponseBodyData Data { get; set; }
        public class DescribePvtzStatisticsZoneOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RefusedDomainCount")]
            [Validation(Required=false)]
            public long? RefusedDomainCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SuddenDropDomainCount")]
            [Validation(Required=false)]
            public long? SuddenDropDomainCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SuddenIncreaseDomainCount")]
            [Validation(Required=false)]
            public long? SuddenIncreaseDomainCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6F1D541-E7A6-447A-A2B5-9F7A20B2A8FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
