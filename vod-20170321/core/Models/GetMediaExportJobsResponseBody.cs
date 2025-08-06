// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaExportJobsResponseBody : TeaModel {
        [NameInMap("FailedJobIds")]
        [Validation(Required=false)]
        public List<string> FailedJobIds { get; set; }

        [NameInMap("MediaExportJobList")]
        [Validation(Required=false)]
        public List<GetMediaExportJobsResponseBodyMediaExportJobList> MediaExportJobList { get; set; }
        public class GetMediaExportJobsResponseBodyMediaExportJobList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("Match")]
            [Validation(Required=false)]
            public string Match { get; set; }

            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("SortBy")]
            [Validation(Required=false)]
            public string SortBy { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public List<string> NonExistJobIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
