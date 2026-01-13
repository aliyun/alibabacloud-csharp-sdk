// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListDatabaseExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Extension list.</para>
        /// </summary>
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public List<ListDatabaseExtensionsResponseBodyExtensions> Extensions { get; set; }
        public class ListDatabaseExtensionsResponseBodyExtensions : TeaModel {
            /// <summary>
            /// <para>The description of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhparser</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The extension name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhparser</para>
            /// </summary>
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

            /// <summary>
            /// <para>The status of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>installed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
