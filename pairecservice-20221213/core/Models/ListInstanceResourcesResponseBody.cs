// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>9763624B-5FBB-5E3A-9193-B1ADB554CEAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListInstanceResourcesResponseBodyResources> Resources { get; set; }
        public class ListInstanceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DataManagement</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-10-13 17:34:52</para>
            /// </summary>
            [NameInMap("GmtCreateAt")]
            [Validation(Required=false)]
            public string GmtCreateAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-10-13 17:34:52</para>
            /// </summary>
            [NameInMap("GmtModifiedAt")]
            [Validation(Required=false)]
            public string GmtModifiedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>reso-2s416t***</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bucket-test-123</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
