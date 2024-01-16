// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeLatestRecordSchemaResponseBody : TeaModel {
        /// <summary>
        /// The output structure information of the playbook.
        /// </summary>
        [NameInMap("PlaybookNodeSchema")]
        [Validation(Required=false)]
        public DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchema PlaybookNodeSchema { get; set; }
        public class DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchema : TeaModel {
            /// <summary>
            /// The structure information.
            /// </summary>
            [NameInMap("NodeSchema")]
            [Validation(Required=false)]
            public List<DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchemaNodeSchema> NodeSchema { get; set; }
            public class DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchemaNodeSchema : TeaModel {
                /// <summary>
                /// The action name of the component.
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// The name of the component.
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The output fields.
                /// </summary>
                [NameInMap("OutputFields")]
                [Validation(Required=false)]
                public List<string> OutputFields { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
