// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListExecutionRiskyTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C04B668D-D2DD-4B40-B6E9-0E3C4F53D5B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about high-risk tasks.</para>
        /// </summary>
        [NameInMap("RiskyTasks")]
        [Validation(Required=false)]
        public List<ListExecutionRiskyTasksResponseBodyRiskyTasks> RiskyTasks { get; set; }
        public class ListExecutionRiskyTasksResponseBodyRiskyTasks : TeaModel {
            /// <summary>
            /// <para>The name of the operation that the high-risk task calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DeleteInstance</para>
            /// </summary>
            [NameInMap("API")]
            [Validation(Required=false)]
            public string API { get; set; }

            /// <summary>
            /// <para>The cloud service in which the high-risk task runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>The details of the high-risk task.</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<string> Task { get; set; }

            /// <summary>
            /// <para>The details of templates to which the high-risk task belongs.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<string> Template { get; set; }

        }

    }

}
