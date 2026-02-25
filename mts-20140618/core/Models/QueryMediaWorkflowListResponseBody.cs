// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowListResponseBody : TeaModel {
        [NameInMap("MediaWorkflowList")]
        [Validation(Required=false)]
        public QueryMediaWorkflowListResponseBodyMediaWorkflowList MediaWorkflowList { get; set; }
        public class QueryMediaWorkflowListResponseBodyMediaWorkflowList : TeaModel {
            [NameInMap("MediaWorkflow")]
            [Validation(Required=false)]
            public List<QueryMediaWorkflowListResponseBodyMediaWorkflowListMediaWorkflow> MediaWorkflow { get; set; }
            public class QueryMediaWorkflowListResponseBodyMediaWorkflowListMediaWorkflow : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("MediaWorkflowId")]
                [Validation(Required=false)]
                public string MediaWorkflowId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Topology")]
                [Validation(Required=false)]
                public string Topology { get; set; }

                [NameInMap("TriggerMode")]
                [Validation(Required=false)]
                public string TriggerMode { get; set; }

            }

        }

        [NameInMap("NonExistMediaWorkflowIds")]
        [Validation(Required=false)]
        public QueryMediaWorkflowListResponseBodyNonExistMediaWorkflowIds NonExistMediaWorkflowIds { get; set; }
        public class QueryMediaWorkflowListResponseBodyNonExistMediaWorkflowIds : TeaModel {
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public List<string> MediaWorkflowId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16CD0CDD-457E-420D-1234-8385075A618B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
