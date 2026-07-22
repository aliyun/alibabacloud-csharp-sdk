// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyScheduledTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A51B1DF-96FF-3BCC-B08C-783161D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of modification results.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ModifyScheduledTaskResponseBodyTasks> Tasks { get; set; }
        public class ModifyScheduledTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The list of batch delivery results for instance scheduled tasks.</para>
            /// </summary>
            [NameInMap("InstanceResults")]
            [Validation(Required=false)]
            public List<ModifyScheduledTaskResponseBodyTasksInstanceResults> InstanceResults { get; set; }
            public class ModifyScheduledTaskResponseBodyTasksInstanceResults : TeaModel {
                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance not found.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acp-4dkmkip0l0uw*****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <para>The updated CAS version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NewVersion")]
            [Validation(Required=false)]
            public int? NewVersion { get; set; }

            /// <summary>
            /// <para>The scheduled task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sch-260705-agbx*****</para>
            /// </summary>
            [NameInMap("ScheduledId")]
            [Validation(Required=false)]
            public string ScheduledId { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
