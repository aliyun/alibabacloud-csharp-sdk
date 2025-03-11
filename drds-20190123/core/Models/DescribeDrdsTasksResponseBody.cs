// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD412DF7-F21D-44CE-88FF-ED24917174A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates information about the tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDrdsTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDrdsTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDrdsTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDrdsTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// <para>Indicates the content of a task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>upgrade_instance</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Indicates the ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64148</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates the state of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAILED</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

    }

}
