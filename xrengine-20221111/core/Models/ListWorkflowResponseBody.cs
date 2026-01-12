// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class ListWorkflowResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkflowResponseBodyData Data { get; set; }
        public class ListWorkflowResponseBodyData : TeaModel {
            [NameInMap("HumanPose")]
            [Validation(Required=false)]
            public List<ListWorkflowResponseBodyDataHumanPose> HumanPose { get; set; }
            public class ListWorkflowResponseBodyDataHumanPose : TeaModel {
                [NameInMap("BizUsage")]
                [Validation(Required=false)]
                public string BizUsage { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

            [NameInMap("Mannequins")]
            [Validation(Required=false)]
            public List<ListWorkflowResponseBodyDataMannequins> Mannequins { get; set; }
            public class ListWorkflowResponseBodyDataMannequins : TeaModel {
                [NameInMap("BizUsage")]
                [Validation(Required=false)]
                public string BizUsage { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

            [NameInMap("Object")]
            [Validation(Required=false)]
            public List<ListWorkflowResponseBodyDataObject> Object { get; set; }
            public class ListWorkflowResponseBodyDataObject : TeaModel {
                [NameInMap("BizUsage")]
                [Validation(Required=false)]
                public string BizUsage { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

            [NameInMap("ObjectGeneration")]
            [Validation(Required=false)]
            public List<ListWorkflowResponseBodyDataObjectGeneration> ObjectGeneration { get; set; }
            public class ListWorkflowResponseBodyDataObjectGeneration : TeaModel {
                [NameInMap("BizUsage")]
                [Validation(Required=false)]
                public string BizUsage { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public List<ListWorkflowResponseBodyDataScene> Scene { get; set; }
            public class ListWorkflowResponseBodyDataScene : TeaModel {
                [NameInMap("BizUsage")]
                [Validation(Required=false)]
                public string BizUsage { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
