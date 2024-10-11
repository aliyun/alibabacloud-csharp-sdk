// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListUserClustersResponseBody : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public ListUserClustersResponseBodyHeaders Headers { get; set; }
        public class ListUserClustersResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1E2CBBA8-C623-4FEE-BC84-9672E460CA39</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListUserClustersResponseBodyResult> Result { get; set; }
        public class ListUserClustersResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>meta</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public ListUserClustersResponseBodyResultMeta Meta { get; set; }
            public class ListUserClustersResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tst</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UserCluster</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mycluster-for-airec</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
