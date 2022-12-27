// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelineRelationsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("pipelineRelations")]
        [Validation(Required=false)]
        public List<ListPipelineRelationsResponseBodyPipelineRelations> PipelineRelations { get; set; }
        public class ListPipelineRelationsResponseBodyPipelineRelations : TeaModel {
            [NameInMap("refObjectId")]
            [Validation(Required=false)]
            public long? RefObjectId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
