// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCOpsplanDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AppCount")]
        [Validation(Required=false)]
        public long? AppCount { get; set; }

        [NameInMap("Executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MessageDetail")]
        [Validation(Required=false)]
        public string MessageDetail { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("TimeSeriesId")]
        [Validation(Required=false)]
        public string TimeSeriesId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public List<QueryLDCOpsplanDetailResponseBodyAppInfos> AppInfos { get; set; }
        public class QueryLDCOpsplanDetailResponseBodyAppInfos : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Executor")]
            [Validation(Required=false)]
            public string Executor { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("GroupNum")]
            [Validation(Required=false)]
            public long? GroupNum { get; set; }

            [NameInMap("GroupStrategy")]
            [Validation(Required=false)]
            public string GroupStrategy { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

            [NameInMap("RollbackRevision")]
            [Validation(Required=false)]
            public string RollbackRevision { get; set; }

            [NameInMap("StandaloneExecutable")]
            [Validation(Required=false)]
            public bool? StandaloneExecutable { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("GroupCollectionList")]
        [Validation(Required=false)]
        public List<QueryLDCOpsplanDetailResponseBodyGroupCollectionList> GroupCollectionList { get; set; }
        public class QueryLDCOpsplanDetailResponseBodyGroupCollectionList : TeaModel {
            [NameInMap("AppGroupList")]
            [Validation(Required=false)]
            public List<QueryLDCOpsplanDetailResponseBodyGroupCollectionListAppGroupList> AppGroupList { get; set; }
            public class QueryLDCOpsplanDetailResponseBodyGroupCollectionListAppGroupList : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("AppIdList")]
                [Validation(Required=false)]
                public List<string> AppIdList { get; set; }

            }

        }

    }

}
