// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsZoneOverviewResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInterAuthStatisticsZoneOverviewResponseBodyData Data { get; set; }
        public class DescribeInterAuthStatisticsZoneOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("RefusedDomainCount")]
            [Validation(Required=false)]
            public long? RefusedDomainCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("SuddenDropDomainCount")]
            [Validation(Required=false)]
            public long? SuddenDropDomainCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>56</para>
            /// </summary>
            [NameInMap("SuddenIncreaseDomainCount")]
            [Validation(Required=false)]
            public long? SuddenIncreaseDomainCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
