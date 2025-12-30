// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSearchLibResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Information about search libraries.</para>
        /// </summary>
        [NameInMap("SearchLibInfoList")]
        [Validation(Required=false)]
        public List<ListSearchLibResponseBodySearchLibInfoList> SearchLibInfoList { get; set; }
        public class ListSearchLibResponseBodySearchLibInfoList : TeaModel {
            [NameInMap("IndexInfo")]
            [Validation(Required=false)]
            public List<ListSearchLibResponseBodySearchLibInfoListIndexInfo> IndexInfo { get; set; }
            public class ListSearchLibResponseBodySearchLibInfoListIndexInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("IndexReadiness")]
                [Validation(Required=false)]
                public string IndexReadiness { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("IndexStatus")]
                [Validation(Required=false)]
                public string IndexStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>face</para>
                /// </summary>
                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

            }

            [NameInMap("SearchLibConfig")]
            [Validation(Required=false)]
            public string SearchLibConfig { get; set; }

            /// <summary>
            /// <para>The search library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>faceSearchLib</para>
            /// </summary>
            [NameInMap("SearchLibName")]
            [Validation(Required=false)]
            public string SearchLibName { get; set; }

            /// <summary>
            /// <para>The status of the search library.</para>
            /// <list type="bullet">
            /// <item><description>normal</description></item>
            /// <item><description>deleting</description></item>
            /// <item><description>deleteFail</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
