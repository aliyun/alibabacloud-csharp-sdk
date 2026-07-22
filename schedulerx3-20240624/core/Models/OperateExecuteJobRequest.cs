// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class OperateExecuteJobRequest : TeaModel {
        [NameInMap("AppGroupId")]
        [Validation(Required=false)]
        public long? AppGroupId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The instance parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name=zhangsan</para>
        /// </summary>
        [NameInMap("InstanceParameters")]
        [Validation(Required=false)]
        public string InstanceParameters { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The label of the specified machine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The workerAddr of the specified machine.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://192.168.***.5:9999/">http://192.168.***.5:9999/</a></para>
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public string Worker { get; set; }

    }

}
