// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutApptenantpathappnamecustompipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutApptenantpathappnamecustompipelineResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutApptenantpathappnamecustompipelineResponseBodyResult : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IterationTemplateId")]
            [Validation(Required=false)]
            public string IterationTemplateId { get; set; }

            [NameInMap("IterationTemplateName")]
            [Validation(Required=false)]
            public string IterationTemplateName { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public string Pipeline { get; set; }

            [NameInMap("PipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            [NameInMap("StageTemplateId")]
            [Validation(Required=false)]
            public string StageTemplateId { get; set; }

            [NameInMap("StageTemplateName")]
            [Validation(Required=false)]
            public string StageTemplateName { get; set; }

            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

        }

    }

}
