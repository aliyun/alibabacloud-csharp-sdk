// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProblemsResponseBodyData> Data { get; set; }
        public class ListProblemsResponseBodyData : TeaModel {
            [NameInMap("affectServices")]
            [Validation(Required=false)]
            public List<ListProblemsResponseBodyDataAffectServices> AffectServices { get; set; }
            public class ListProblemsResponseBodyDataAffectServices : TeaModel {
                [NameInMap("serviceDescription")]
                [Validation(Required=false)]
                public string ServiceDescription { get; set; }

                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("cancelTime")]
            [Validation(Required=false)]
            public string CancelTime { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("discoverTime")]
            [Validation(Required=false)]
            public string DiscoverTime { get; set; }

            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            [NameInMap("isManual")]
            [Validation(Required=false)]
            public bool? IsManual { get; set; }

            [NameInMap("isUpgrade")]
            [Validation(Required=false)]
            public bool? IsUpgrade { get; set; }

            [NameInMap("mainHandlerId")]
            [Validation(Required=false)]
            public long? MainHandlerId { get; set; }

            [NameInMap("mainHandlerIsValid")]
            [Validation(Required=false)]
            public long? MainHandlerIsValid { get; set; }

            [NameInMap("mainHandlerName")]
            [Validation(Required=false)]
            public string MainHandlerName { get; set; }

            [NameInMap("problemId")]
            [Validation(Required=false)]
            public long? ProblemId { get; set; }

            [NameInMap("problemLevel")]
            [Validation(Required=false)]
            public string ProblemLevel { get; set; }

            [NameInMap("problemName")]
            [Validation(Required=false)]
            public string ProblemName { get; set; }

            [NameInMap("problemNumber")]
            [Validation(Required=false)]
            public string ProblemNumber { get; set; }

            [NameInMap("problemStatus")]
            [Validation(Required=false)]
            public string ProblemStatus { get; set; }

            [NameInMap("recoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }

            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public string RelatedServiceId { get; set; }

            [NameInMap("replayTime")]
            [Validation(Required=false)]
            public string ReplayTime { get; set; }

            [NameInMap("serviceDeletedType")]
            [Validation(Required=false)]
            public int? ServiceDeletedType { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
