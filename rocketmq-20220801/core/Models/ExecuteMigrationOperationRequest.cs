// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ExecuteMigrationOperationRequest : TeaModel {
        /// <summary>
        /// <para>The operation parameter.</para>
        /// </summary>
        [NameInMap("operationParam")]
        [Validation(Required=false)]
        public ExecuteMigrationOperationRequestOperationParam OperationParam { get; set; }
        public class ExecuteMigrationOperationRequestOperationParam : TeaModel {
            /// <summary>
            /// <para>The parameter information. The parameter type is a JSON string. See the examples below.</para>
            /// <para>The valid values for the action field are as follows:</para>
            /// <list type="bullet">
            /// <item><description>MIGRATE_FORWARD (migrate forward)</description></item>
            /// <item><description>MIGRATE_BACKWARD (migrate backward)</description></item>
            /// </list>
            /// <para>The valid values for the targetStage field are as follows:</para>
            /// <list type="bullet">
            /// <item><description>MIGRATE_WAIT (read from and write to the source cluster)</description></item>
            /// <item><description>DOUBLE_READ (write to the source cluster with redundant reads)</description></item>
            /// <item><description>SWITCH_WRITE (write to the destination cluster with redundant reads)</description></item>
            /// <item><description>MIGRATE_FINISH (read from and write to the destination cluster)</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>For migration forward, you can only advance one stage at a time in order.</description></item>
            /// <item><description>For migration rollback, you can roll back to any previous stage.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Migrate forward: {&quot;action&quot;:&quot;MIGRATE_FORWARD&quot;,&quot;targetStage&quot;:&quot;MIGRATE_FINISH&quot;}</para>
            /// <para>Migrate backward: {&quot;action&quot;:&quot;MIGRATE_BACKWARD&quot;,&quot;targetStage&quot;:&quot;MIGRATE_WAIT&quot;}</para>
            /// </summary>
            [NameInMap("paramData")]
            [Validation(Required=false)]
            public object ParamData { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-x0r37kel***</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
