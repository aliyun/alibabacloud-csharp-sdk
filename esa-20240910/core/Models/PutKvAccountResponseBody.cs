// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PutKvAccountResponseBody : TeaModel {
        [NameInMap("NamespaceList")]
        [Validation(Required=false)]
        public List<PutKvAccountResponseBodyNamespaceList> NamespaceList { get; set; }
        public class PutKvAccountResponseBodyNamespaceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>the first namespace</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_namespace</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>643355322374688768</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public int? NamespaceQuota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NamespaceUsed")]
        [Validation(Required=false)]
        public int? NamespaceUsed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
