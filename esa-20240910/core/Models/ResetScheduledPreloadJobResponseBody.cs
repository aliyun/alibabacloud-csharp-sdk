// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ResetScheduledPreloadJobResponseBody : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string Domains { get; set; }

        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public string ErrorInfo { get; set; }

        [NameInMap("FailedFileOss")]
        [Validation(Required=false)]
        public string FailedFileOss { get; set; }

        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("InsertWay")]
        [Validation(Required=false)]
        public string InsertWay { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("TaskSubmitted")]
        [Validation(Required=false)]
        public int? TaskSubmitted { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("UrlCount")]
        [Validation(Required=false)]
        public int? UrlCount { get; set; }

        [NameInMap("UrlSubmitted")]
        [Validation(Required=false)]
        public int? UrlSubmitted { get; set; }

    }

}
