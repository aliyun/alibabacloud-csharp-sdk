// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>The trend of the number of auto triggered node instances within the specified period of time.</para>
        /// </summary>
        [NameInMap("InstanceCounts")]
        [Validation(Required=false)]
        public List<ListInstanceAmountResponseBodyInstanceCounts> InstanceCounts { get; set; }
        public class ListInstanceAmountResponseBodyInstanceCounts : TeaModel {
            /// <summary>
            /// <para>The number of auto triggered node instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The data timestamp at which the number of auto triggered node instances was obtained. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623772800000</para>
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
