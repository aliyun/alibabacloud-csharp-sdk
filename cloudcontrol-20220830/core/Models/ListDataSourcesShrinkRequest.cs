// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListDataSourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the property. RegionId is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionId</para>
        /// </summary>
        [NameInMap("attributeName")]
        [Validation(Required=false)]
        public string AttributeName { get; set; }

        /// <summary>
        /// <para>The filter conditions. JSON format:{&quot;key1&quot;:&quot;value1&quot;}.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

    }

}
