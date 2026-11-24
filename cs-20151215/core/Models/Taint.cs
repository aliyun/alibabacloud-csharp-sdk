// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Taint : TeaModel {
        /// <summary>
        /// <para>The scheduling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NoSchedule</c>: Not tolerated. It affects only the scheduling process and applies only to newly added pods. Already scheduled pods are not affected.</para>
        /// </description></item>
        /// <item><description><para><c>NoExecute</c>: Not tolerated. Pods are evicted when the taint changes.</para>
        /// </description></item>
        /// <item><description><para><c>PreferNoSchedule</c>: Soft constraint. Existing pods on the node are not affected. The system tries to avoid scheduling pods that do not meet the requirements to the node.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>NoSchedule</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSchedule</para>
        /// </summary>
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// <para>The key of the taint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The value of the taint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
