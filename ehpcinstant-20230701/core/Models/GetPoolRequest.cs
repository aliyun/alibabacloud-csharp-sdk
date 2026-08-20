// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetPoolRequest : TeaModel {
        /// <summary>
        /// <para>The resource pool name.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 15 characters in length.</description></item>
        /// <item><description>The name can contain digits, uppercase letters, lowercase letters, underscores (_), and periods (.).</description></item>
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
