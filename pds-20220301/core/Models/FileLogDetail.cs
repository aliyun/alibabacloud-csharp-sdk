// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileLogDetail : TeaModel {
        [NameInMap("decompress_file_list")]
        [Validation(Required=false)]
        public List<string> DecompressFileList { get; set; }

        [NameInMap("new_name")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        [NameInMap("parent_path")]
        [Validation(Required=false)]
        public string ParentPath { get; set; }

        [NameInMap("rev_version")]
        [Validation(Required=false)]
        public long? RevVersion { get; set; }

        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("to_parent_path")]
        [Validation(Required=false)]
        public string ToParentPath { get; set; }

        [NameInMap("to_parent_path_type")]
        [Validation(Required=false)]
        public string ToParentPathType { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
