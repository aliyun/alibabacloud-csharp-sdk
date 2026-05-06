// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateTaskGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CreateTaskGroupResponseBodyResultObject ResultObject { get; set; }
        public class CreateTaskGroupResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1750645267000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>345298</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public int? CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("GroupStatus")]
            [Validation(Required=false)]
            public string GroupStatus { get; set; }

            [NameInMap("SampleNames")]
            [Validation(Required=false)]
            public List<string> SampleNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SubTaskCount")]
            [Validation(Required=false)]
            public int? SubTaskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>g-0jlcreertd0p471l6f72</para>
            /// </summary>
            [NameInMap("TaskGroupId")]
            [Validation(Required=false)]
            public int? TaskGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GroupTest</para>
            /// </summary>
            [NameInMap("TaskGroupName")]
            [Validation(Required=false)]
            public string TaskGroupName { get; set; }

        }

    }

}
