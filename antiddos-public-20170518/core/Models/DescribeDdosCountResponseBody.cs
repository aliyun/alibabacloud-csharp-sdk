// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of assets that are under DDoS attacks.</para>
        /// </summary>
        [NameInMap("DdosCount")]
        [Validation(Required=false)]
        public DescribeDdosCountResponseBodyDdosCount DdosCount { get; set; }
        public class DescribeDdosCountResponseBodyDdosCount : TeaModel {
            /// <summary>
            /// <para>The number of assets for which blackhole filtering is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BlackholeCount")]
            [Validation(Required=false)]
            public int? BlackholeCount { get; set; }

            /// <summary>
            /// <para>The number of assets for which traffic scrubbing is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }

            /// <summary>
            /// <para>The total number of assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstacenCount")]
            [Validation(Required=false)]
            public int? InstacenCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D66C762-324E-51CE-B461-2007996087B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
