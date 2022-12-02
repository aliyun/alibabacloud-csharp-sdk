// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DatasetItemVO : TeaModel {
        [NameInMap("AsyncTaskList")]
        [Validation(Required=false)]
        public List<AsyncTaskVO> AsyncTaskList { get; set; }

        [NameInMap("DatasetStatus")]
        [Validation(Required=false)]
        public int? DatasetStatus { get; set; }

        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public int? DatasetType { get; set; }

        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        [NameInMap("FileSystem")]
        [Validation(Required=false)]
        public string FileSystem { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        [NameInMap("MoreInfo")]
        [Validation(Required=false)]
        public string MoreInfo { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("ProjectsLinked")]
        [Validation(Required=false)]
        public List<ProjectDetailsLiteVO> ProjectsLinked { get; set; }

        [NameInMap("RecentTaskStatus")]
        [Validation(Required=false)]
        public int? RecentTaskStatus { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
