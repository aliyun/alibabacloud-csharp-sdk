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
        /// <item><description><c>NoSchedule</c>: This taint is not tolerated. However, pods that are already scheduled to the node are not affected.</description></item>
        /// <item><description><c>NoExecute</c>: Pods that do not tolerate this taint are evicted after this taint is added to the node.</description></item>
        /// <item><description><c>PreferNoSchedule</c>: This value specifies a soft limit on pods. Existing pods on the node are not affected. The scheduler attempts to avoid scheduling pods that cannot tolerate the taint to the node.</description></item>
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
        /// <para>The <c>key</c> of the taint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The <c>value</c> of the taint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
