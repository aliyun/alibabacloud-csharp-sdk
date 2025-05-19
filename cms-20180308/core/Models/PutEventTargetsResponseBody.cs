// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class PutEventTargetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyContactParameters ContactParameters { get; set; }
        public class PutEventTargetsResponseBodyContactParameters : TeaModel {
            [NameInMap("ContactParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyContactParametersContactParameter> ContactParameter { get; set; }
            public class PutEventTargetsResponseBodyContactParametersContactParameter : TeaModel {
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        [NameInMap("FailedContactParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyFailedContactParameters FailedContactParameters { get; set; }
        public class PutEventTargetsResponseBodyFailedContactParameters : TeaModel {
            [NameInMap("ContactParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyFailedContactParametersContactParameter> ContactParameter { get; set; }
            public class PutEventTargetsResponseBodyFailedContactParametersContactParameter : TeaModel {
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        [NameInMap("FailedFcParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyFailedFcParameters FailedFcParameters { get; set; }
        public class PutEventTargetsResponseBodyFailedFcParameters : TeaModel {
            [NameInMap("FcParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyFailedFcParametersFcParameter> FcParameter { get; set; }
            public class PutEventTargetsResponseBodyFailedFcParametersFcParameter : TeaModel {
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        [NameInMap("FailedMnsParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyFailedMnsParameters FailedMnsParameters { get; set; }
        public class PutEventTargetsResponseBodyFailedMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyFailedMnsParametersMnsParameter> MnsParameter { get; set; }
            public class PutEventTargetsResponseBodyFailedMnsParametersMnsParameter : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        [NameInMap("FailedParameterCount")]
        [Validation(Required=false)]
        public string FailedParameterCount { get; set; }

        [NameInMap("FailedSlsParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyFailedSlsParameters FailedSlsParameters { get; set; }
        public class PutEventTargetsResponseBodyFailedSlsParameters : TeaModel {
            [NameInMap("FailedSlsParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyFailedSlsParametersFailedSlsParameter> FailedSlsParameter { get; set; }
            public class PutEventTargetsResponseBodyFailedSlsParametersFailedSlsParameter : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyFcParameters FcParameters { get; set; }
        public class PutEventTargetsResponseBodyFcParameters : TeaModel {
            [NameInMap("FcParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyFcParametersFcParameter> FcParameter { get; set; }
            public class PutEventTargetsResponseBodyFcParametersFcParameter : TeaModel {
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public PutEventTargetsResponseBodyMnsParameters MnsParameters { get; set; }
        public class PutEventTargetsResponseBodyMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<PutEventTargetsResponseBodyMnsParametersMnsParameter> MnsParameter { get; set; }
            public class PutEventTargetsResponseBodyMnsParametersMnsParameter : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        [NameInMap("ParameterCount")]
        [Validation(Required=false)]
        public string ParameterCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
