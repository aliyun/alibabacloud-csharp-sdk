// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskReferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This helps troubleshoot issues later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFlowControlTaskReferenceResponseBodyResult Result { get; set; }
        public class ListFlowControlTaskReferenceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The average exposure rate of the item pool in the last seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("last7PvPercent")]
            [Validation(Required=false)]
            public double? Last7PvPercent { get; set; }

            /// <summary>
            /// <para>The average number of exposures for the items in the selected scene in the last seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("last7ScenePv")]
            [Validation(Required=false)]
            public double? Last7ScenePv { get; set; }

            /// <summary>
            /// <para>The average number of exposures for the item pool in the selected scene in the last seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("last7TaskPv")]
            [Validation(Required=false)]
            public double? Last7TaskPv { get; set; }

            /// <summary>
            /// <para>The exposure rate of the item pool yesterday.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("lastPvPercent")]
            [Validation(Required=false)]
            public double? LastPvPercent { get; set; }

            /// <summary>
            /// <para>The total number of exposures for the items in the selected scene yesterday.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("lastScenePv")]
            [Validation(Required=false)]
            public long? LastScenePv { get; set; }

            /// <summary>
            /// <para>The number of exposures for the item pool in the selected scene yesterday.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("lastTaskPv")]
            [Validation(Required=false)]
            public long? LastTaskPv { get; set; }

            /// <summary>
            /// <para>The ID of the reference data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>421351235918</para>
            /// </summary>
            [NameInMap("referenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

        }

    }

}
