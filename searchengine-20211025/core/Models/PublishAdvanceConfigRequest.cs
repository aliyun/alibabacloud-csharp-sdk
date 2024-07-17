// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class PublishAdvanceConfigRequest : TeaModel {
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
        public List<PublishAdvanceConfigRequestFiles> Files { get; set; }
        public class PublishAdvanceConfigRequestFiles : TeaModel {
            /// <summary>
            /// The information about the advanced configuration.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public PublishAdvanceConfigRequestFilesConfig Config { get; set; }
            public class PublishAdvanceConfigRequestFilesConfig : TeaModel {
                /// <summary>
                /// The file content.
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The variables.
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public Dictionary<string, FilesConfigVariablesValue> Variables { get; set; }

            }

            /// <summary>
            /// The directory name.
            /// </summary>
            [NameInMap("dirName")]
            [Validation(Required=false)]
            public string DirName { get; set; }

            /// <summary>
            /// The file name.
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The operation type. Valid values: UPDATE and DELETE. Default value: UPDATE.
            /// </summary>
            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// The path of the Object Storage Service (OSS) object.
            /// </summary>
            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// The path of the parent directory.
            /// </summary>
            [NameInMap("parentFullPath")]
            [Validation(Required=false)]
            public string ParentFullPath { get; set; }

        }

    }

}
