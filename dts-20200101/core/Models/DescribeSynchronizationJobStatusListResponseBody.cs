// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SynchronizationJobListStatusList")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList> SynchronizationJobListStatusList { get; set; }
        public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList : TeaModel {
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            [NameInMap("SynchronizationDirectionInfoList")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList> SynchronizationDirectionInfoList { get; set; }
            public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SynchronizationDirection")]
                [Validation(Required=false)]
                public string SynchronizationDirection { get; set; }

                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

            }

        }

    }

}
