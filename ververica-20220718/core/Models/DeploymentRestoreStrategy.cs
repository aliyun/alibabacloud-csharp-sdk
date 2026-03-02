// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeploymentRestoreStrategy : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow specific operator states to be skipped. This parameter is required only when a Python deployment or a JAR deployment is resumed with state data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRUE</para>
        /// </summary>
        [NameInMap("allowNonRestoredState")]
        [Validation(Required=false)]
        public bool? AllowNonRestoredState { get; set; }

        /// <summary>
        /// <para>The time point at which the deployment is started without states. You must enter a 13-digit timestamp. If you set the kind parameter to NONE, you can configure this parameter to allow all source tables for which the startTime parameter is configured to read data from the specified time point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660293803155</para>
        /// </summary>
        [NameInMap("jobStartTimeInMs")]
        [Validation(Required=false)]
        public long? JobStartTimeInMs { get; set; }

        /// <summary>
        /// <para>The type of the start offset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NONE: The deployment is started without states.</description></item>
        /// <item><description>LATEST_SAVEPOINT: The deployment is started from the latest savepoint.</description></item>
        /// <item><description>FROM_SAVEPOINT: The deployment is started from the specified savepoint.</description></item>
        /// <item><description>LATEST_STATE: The deployment is started from the latest state of the deployment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST_STATE</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The ID of the savepoint for starting the deployment. This parameter is required when the kind parameter is set to FROM_SAVEPOINT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("savepointId")]
        [Validation(Required=false)]
        public string SavepointId { get; set; }

    }

}
