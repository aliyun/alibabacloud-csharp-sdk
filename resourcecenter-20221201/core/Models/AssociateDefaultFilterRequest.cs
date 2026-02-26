// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class AssociateDefaultFilterRequest : TeaModel {
        /// <summary>
        /// <para>The name of the filter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>所有ECS实例资源</para>
        /// </summary>
        [NameInMap("FilterName")]
        [Validation(Required=false)]
        public string FilterName { get; set; }

    }

}
