// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTaskExecutionInvocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E011F98-4EE5-5E3A-8FA3-D38F2C531C1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskExecutionInvocations")]
        [Validation(Required=false)]
        public List<ListTaskExecutionInvocationsResponseBodyTaskExecutionInvocations> TaskExecutionInvocations { get; set; }
        public class ListTaskExecutionInvocationsResponseBodyTaskExecutionInvocations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>t-hz0jdfwd9f****</para>
            /// </summary>
            [NameInMap("InvocationId")]
            [Validation(Required=false)]
            public string InvocationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exec-xxxx.t0001</para>
            /// </summary>
            [NameInMap("InvocationTaskExecutionId")]
            [Validation(Required=false)]
            public string InvocationTaskExecutionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TaskName</para>
            /// </summary>
            [NameInMap("InvocationTaskName")]
            [Validation(Required=false)]
            public string InvocationTaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
