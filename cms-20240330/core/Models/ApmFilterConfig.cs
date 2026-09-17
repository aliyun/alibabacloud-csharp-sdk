// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmFilterConfig : TeaModel {
        /// <summary>
        /// <para>The dimension key name of the APM query filter condition. Specifies which dimension to filter by, such as hostname or service name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host.name</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The matching type of the APM query filter condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL: Matches all values.</description></item>
        /// <item><description>EQ: Exact match.</description></item>
        /// <item><description>NE: Not equal to.</description></item>
        /// <item><description>DISABLED: Disables the filter condition.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EQ</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The filter value. Can be empty when type is set to ALL or DISABLED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
