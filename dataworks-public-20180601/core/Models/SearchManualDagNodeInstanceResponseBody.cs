// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class SearchManualDagNodeInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchManualDagNodeInstanceResponseBodyData Data { get; set; }
        public class SearchManualDagNodeInstanceResponseBodyData : TeaModel {
            [NameInMap("NodeInsInfo")]
            [Validation(Required=false)]
            public List<SearchManualDagNodeInstanceResponseBodyDataNodeInsInfo> NodeInsInfo { get; set; }
            public class SearchManualDagNodeInstanceResponseBodyDataNodeInsInfo : TeaModel {
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public string BeginRunningTime { get; set; }

                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public string BeginWaitResTime { get; set; }

                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public string BeginWaitTimeTime { get; set; }

                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public string Bizdate { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                [NameInMap("DagType")]
                [Validation(Required=false)]
                public int? DagType { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
