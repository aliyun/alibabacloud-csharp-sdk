// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkBaiLianParameters : TeaModel {
        [NameInMap("After")]
        [Validation(Required=false)]
        public SinkBaiLianParametersAfter After { get; set; }
        public class SinkBaiLianParametersAfter : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        [NameInMap("Before")]
        [Validation(Required=false)]
        public SinkBaiLianParametersBefore Before { get; set; }
        public class SinkBaiLianParametersBefore : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Context")]
        [Validation(Required=false)]
        public object Context { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public object Extend { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOffset Offset { get; set; }
        public class SinkBaiLianParametersOffset : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Op")]
        [Validation(Required=false)]
        public SinkBaiLianParametersOp Op { get; set; }
        public class SinkBaiLianParametersOp : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Partition")]
        [Validation(Required=false)]
        public SinkBaiLianParametersPartition Partition { get; set; }
        public class SinkBaiLianParametersPartition : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
