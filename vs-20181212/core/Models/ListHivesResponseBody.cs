// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListHivesResponseBody : TeaModel {
        [NameInMap("Hives")]
        [Validation(Required=false)]
        public List<ListHivesResponseBodyHives> Hives { get; set; }
        public class ListHivesResponseBodyHives : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-14T15:20:37+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hive-3b506f0868a7451ba15e0e890706033a</para>
            /// </summary>
            [NameInMap("HiveId")]
            [Validation(Required=false)]
            public string HiveId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yy-test2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
