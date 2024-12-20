// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListInstanceExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried extensions.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListInstanceExtensionsResponseBodyItems> Items { get; set; }
        public class ListInstanceExtensionsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The description of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>citext usage</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The extension ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExtensionId")]
            [Validation(Required=false)]
            public string ExtensionId { get; set; }

            /// <summary>
            /// <para>The names of the databases in which the extension is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstalledDatabases")]
            [Validation(Required=false)]
            public string InstalledDatabases { get; set; }

            /// <summary>
            /// <para>Indicates whether an instance restart is required after you install the extension for the extension to take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsInstallNeedRestart")]
            [Validation(Required=false)]
            public bool? IsInstallNeedRestart { get; set; }

            /// <summary>
            /// <para>The latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The name of the extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>citext</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7565770E-7C45-462D-BA4A-8A5396F2CAD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
