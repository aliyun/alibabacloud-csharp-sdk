// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyAdvanceConfigRequest : TeaModel {
        /// <summary>
        /// The content of the advanced configuration that is returned.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The type of the configuration content. Valid values: FILE, GIT, HTTP, and ODPS.
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The description of the advanced configuration.
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// The files.
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<ModifyAdvanceConfigRequestFiles> Files { get; set; }
        public class ModifyAdvanceConfigRequestFiles : TeaModel {
            /// <summary>
            /// The full path of the file.
            /// </summary>
            [NameInMap("fullPathName")]
            [Validation(Required=false)]
            public string FullPathName { get; set; }

            /// <summary>
            /// Specifies whether the file is a directory.
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// Specifies whether the file is a template.
            /// </summary>
            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            /// <summary>
            /// The node name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The name of the advanced configuration.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The status of the advanced configuration. Valid values: drafting: The advanced configuration is in the draft state. used: The advanced configuration is being used. unused: The advanced configuration is not used. trash: The advanced configuration is being deleted.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the advanced configuration was updated.
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
