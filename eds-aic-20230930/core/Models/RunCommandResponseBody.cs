// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunCommandResponseBody : TeaModel {
        /// <summary>
        /// <para>The command execution ID. You can use this ID to query the command execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-gov2ujrk32v4****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>440D7342-5E7C-B2DB-D0B4EAC2BDF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of command execution information for each cloud phone instance.</para>
        /// </summary>
        [NameInMap("RunCommandInfos")]
        [Validation(Required=false)]
        public List<RunCommandResponseBodyRunCommandInfos> RunCommandInfos { get; set; }
        public class RunCommandResponseBodyRunCommandInfos : TeaModel {
            /// <summary>
            /// <para>The instance-level child task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ChildTaskId")]
            [Validation(Required=false)]
            public string ChildTaskId { get; set; }

            /// <summary>
            /// <para>The cloud phone instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-uto81vfd8t8z****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The command execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B8ED2BA9-0C6A-5643-818F-B5D60A64****</para>
            /// </summary>
            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

        }

        /// <summary>
        /// <para>The batch task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
