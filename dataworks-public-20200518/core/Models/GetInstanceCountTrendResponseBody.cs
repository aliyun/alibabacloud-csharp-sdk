// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceCountTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The quantity trend of instances.</para>
        /// </summary>
        [NameInMap("InstanceCounts")]
        [Validation(Required=false)]
        public List<GetInstanceCountTrendResponseBodyInstanceCounts> InstanceCounts { get; set; }
        public class GetInstanceCountTrendResponseBodyInstanceCounts : TeaModel {
            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The data timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600963200000</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527adhfj****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
