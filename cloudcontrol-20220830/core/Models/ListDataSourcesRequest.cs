// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListDataSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the attribute. Only <c>RegionId</c> is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionId</para>
        /// </summary>
        [NameInMap("attributeName")]
        [Validation(Required=false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// <para>The filter condition. The value must be a JSON string in the {&quot;key1&quot;:&quot;value1&quot;} format.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

    }

}
