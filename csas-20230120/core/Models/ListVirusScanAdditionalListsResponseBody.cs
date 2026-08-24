// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanAdditionalListsResponseBody : TeaModel {
        [NameInMap("AdditionalLists")]
        [Validation(Required=false)]
        public List<ListVirusScanAdditionalListsResponseBodyAdditionalLists> AdditionalLists { get; set; }
        public class ListVirusScanAdditionalListsResponseBodyAdditionalLists : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FileSuffix</para>
            /// </summary>
            [NameInMap("AdditionalType")]
            [Validation(Required=false)]
            public string AdditionalType { get; set; }

            [NameInMap("Lists")]
            [Validation(Required=false)]
            public List<ListVirusScanAdditionalListsResponseBodyAdditionalListsLists> Lists { get; set; }
            public class ListVirusScanAdditionalListsResponseBodyAdditionalListsLists : TeaModel {
                [NameInMap("ListDetail")]
                [Validation(Required=false)]
                public List<ListVirusScanAdditionalListsResponseBodyAdditionalListsListsListDetail> ListDetail { get; set; }
                public class ListVirusScanAdditionalListsResponseBodyAdditionalListsListsListDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-08-21 10:24:31</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>.tmp</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>additional-list-4d7b1e9a6c38****</para>
                    /// </summary>
                    [NameInMap("ListId")]
                    [Validation(Required=false)]
                    public string ListId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Whitelist</para>
                /// </summary>
                [NameInMap("ListType")]
                [Validation(Required=false)]
                public string ListType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
