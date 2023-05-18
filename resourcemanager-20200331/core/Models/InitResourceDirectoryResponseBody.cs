// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class InitResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resource directory.
        /// </summary>
        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public InitResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class InitResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// The time when the resource directory was enabled.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the enterprise management account.
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// The name of the enterprise management account.
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// The ID of the root folder.
            /// </summary>
            [NameInMap("RootFolderId")]
            [Validation(Required=false)]
            public string RootFolderId { get; set; }

        }

    }

}
