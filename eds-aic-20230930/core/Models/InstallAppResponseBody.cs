// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class InstallAppResponseBody : TeaModel {
        [NameInMap("ChildTaskInfo")]
        [Validation(Required=false)]
        public List<InstallAppResponseBodyChildTaskInfo> ChildTaskInfo { get; set; }
        public class InstallAppResponseBodyChildTaskInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-ybde48cevxxxx</para>
            /// </summary>
            [NameInMap("ChildTaskId")]
            [Validation(Required=false)]
            public string ChildTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-ty3bnd7b9xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5138F7E-46B5-526A-8C99-82DEAE6B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-14xwibw7yp73q****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
