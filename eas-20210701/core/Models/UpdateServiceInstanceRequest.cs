// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the current instance is an instance unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsReplica")]
        [Validation(Required=false)]
        public bool? IsReplica { get; set; }

        /// <summary>
        /// <para>Specifies whether to isolate the service instance. After an instance is isolated, it is no longer managed by the controller, and a new instance is created. The isolated instance is used to preserve the state or for debugging. Note: An isolated instance cannot be unisolated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The instance is isolated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Detach")]
        [Validation(Required=false)]
        public bool? Detach { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public bool? Hibernate { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance receives traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The instance receives traffic.</description></item>
        /// <item><description>false: The instance does not receive traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Isolate")]
        [Validation(Required=false)]
        public bool? Isolate { get; set; }

    }

}
