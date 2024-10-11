// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKvAccountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1 GB</para>
        /// </summary>
        [NameInMap("CapacityString")]
        [Validation(Required=false)]
        public string CapacityString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10048576</para>
        /// </summary>
        [NameInMap("CapacityUsed")]
        [Validation(Required=false)]
        public long? CapacityUsed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100 MB</para>
        /// </summary>
        [NameInMap("CapacityUsedString")]
        [Validation(Required=false)]
        public string CapacityUsedString { get; set; }

        [NameInMap("NamespaceList")]
        [Validation(Required=false)]
        public List<GetKvAccountResponseBodyNamespaceList> NamespaceList { get; set; }
        public class GetKvAccountResponseBodyNamespaceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1 GB</para>
            /// </summary>
            [NameInMap("CapacityString")]
            [Validation(Required=false)]
            public string CapacityString { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100048576</para>
            /// </summary>
            [NameInMap("CapacityUsed")]
            [Validation(Required=false)]
            public long? CapacityUsed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100 MB</para>
            /// </summary>
            [NameInMap("CapacityUsedString")]
            [Validation(Required=false)]
            public string CapacityUsedString { get; set; }

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
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
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
