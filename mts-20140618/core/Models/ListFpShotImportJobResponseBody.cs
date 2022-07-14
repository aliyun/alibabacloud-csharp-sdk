// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotImportJobResponseBody : TeaModel {
        [NameInMap("FpShotImportJobList")]
        [Validation(Required=false)]
        public List<ListFpShotImportJobResponseBodyFpShotImportJobList> FpShotImportJobList { get; set; }
        public class ListFpShotImportJobResponseBodyFpShotImportJobList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("FpDBId")]
            [Validation(Required=false)]
            public string FpDBId { get; set; }

            [NameInMap("FpImportConfig")]
            [Validation(Required=false)]
            public string FpImportConfig { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("ProcessMessage")]
            [Validation(Required=false)]
            public string ProcessMessage { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public List<string> NonExistIds { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
