// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConvertJobResponseBody : TeaModel {
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetMediaConvertJobResponseBodyJob Job { get; set; }
        public class GetMediaConvertJobResponseBodyJob : TeaModel {
            [NameInMap("ClientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetMediaConvertJobResponseBodyJobConfig Config { get; set; }
            public class GetMediaConvertJobResponseBodyJobConfig : TeaModel {
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<MediaConvertInput> Inputs { get; set; }

                [NameInMap("OutputGroups")]
                [Validation(Required=false)]
                public List<MediaConvertOutputGroup> OutputGroups { get; set; }

                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public List<MediaConvertOutput> Outputs { get; set; }

            }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("OutputDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputDetail> OutputDetails { get; set; }

            [NameInMap("OutputGroupDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputGroupDetail> OutputGroupDetails { get; set; }

            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
