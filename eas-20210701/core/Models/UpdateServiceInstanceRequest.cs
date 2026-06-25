// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the instance is a replica.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsReplica")]
        [Validation(Required=false)]
        public bool? IsReplica { get; set; }

        /// <summary>
        /// <para>Specifies whether to fence the service instance. After an instance is fenced, it is no longer managed by the VPC controller and a new instance is created. The fenced instance is reserved for troubleshooting or debugging. Note: You cannot unfence an instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Fences the instance.</description></item>
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
        /// <para>This parameter is for an invitational preview. It is not generally available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public bool? Hibernate { get; set; }

        /// <summary>
        /// <para>Specifies whether to isolate the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The instance is isolated and does not receive traffic.</para>
        /// </description></item>
        /// <item><description><para>false: The instance is not isolated and receives traffic.</para>
        /// </description></item>
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
