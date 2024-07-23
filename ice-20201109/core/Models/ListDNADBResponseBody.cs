// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDNADBResponseBody : TeaModel {
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public List<ListDNADBResponseBodyDBList> DBList { get; set; }
        public class ListDNADBResponseBodyDBList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>88c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Video</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
