// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetPoolRequest : TeaModel {
        /// <summary>
        /// <para>The name of the resource pool.</para>
        /// <list type="bullet">
        /// <item><description><para>The name can be up to 15 characters long.</para>
        /// </description></item>
        /// <item><description><para>The name can contain letters, digits, underscores (_), and periods (.).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PoolTest</para>
        /// </summary>
        [NameInMap("PoolName")]
        [Validation(Required=false)]
        public string PoolName { get; set; }

    }

}
