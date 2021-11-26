// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyData Data { get; set; }
        public class ListApplicationsResponseBodyData : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyDataApplications> Applications { get; set; }
            public class ListApplicationsResponseBodyDataApplications : TeaModel {
                public bool? AppDeletingStatus { get; set; }
                public string AppDescription { get; set; }
                public string AppId { get; set; }
                public string AppName { get; set; }
                public int? Instances { get; set; }
                public string NamespaceId { get; set; }
                public string RegionId { get; set; }
                public int? RunningInstances { get; set; }
                public List<ListApplicationsResponseBodyDataApplicationsTags> Tags { get; set; }
                public class ListApplicationsResponseBodyDataApplicationsTags : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
