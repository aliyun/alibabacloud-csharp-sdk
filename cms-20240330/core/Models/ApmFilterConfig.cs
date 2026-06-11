// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmFilterConfig : TeaModel {
        /// <summary>
        /// <para>The tag key to filter by. For example, to filter traces by region, set this parameter to <c>RegionId</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The comparison operator used to match the tag\&quot;s value. Valid values: <c>EQUAL</c> and <c>NOT_EQUAL</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value to compare against the tag\&quot;s value. Used with the <c>key</c> and <c>type</c> parameters to form a complete filter condition.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
