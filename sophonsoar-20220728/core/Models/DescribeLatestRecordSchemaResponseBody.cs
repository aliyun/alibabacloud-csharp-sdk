// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeLatestRecordSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>The output structure information of the playbook.</para>
        /// </summary>
        [NameInMap("PlaybookNodeSchema")]
        [Validation(Required=false)]
        public DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchema PlaybookNodeSchema { get; set; }
        public class DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchema : TeaModel {
            /// <summary>
            /// <para>The structure information.</para>
            /// </summary>
            [NameInMap("NodeSchema")]
            [Validation(Required=false)]
            public List<DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchemaNodeSchema> NodeSchema { get; set; }
            public class DescribeLatestRecordSchemaResponseBodyPlaybookNodeSchemaNodeSchema : TeaModel {
                /// <summary>
                /// <para>The action name of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>formatedata</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>The name of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataFormat</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataFormat_1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The output fields.</para>
                /// </summary>
                [NameInMap("OutputFields")]
                [Validation(Required=false)]
                public List<string> OutputFields { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10B92EE1-4597-593B-A131-7A17D25EF5C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
