// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the blacklist policies. Separate multiple IDs with commas (,). You can specify up to 50 IDs.</para>
        /// <para>For information about how to obtain the ID of a blacklist policy, see <a href="https://help.aliyun.com/document_detail/457257.html">DescribeMetricRuleBlackList</a>.</para>
        /// <remarks>
        /// <para>You can also set this parameter to a JSON array. Example: <c>[&quot;a9ad2ac2-3ed9-11ed-b878-0242ac12****&quot;,&quot;5cb8a9a4-198f-4651-a353-f8b28788****&quot;]</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9ad2ac2-3ed9-11ed-b878-0242ac12****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the blacklist policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The blacklist policy is enabled.</description></item>
        /// <item><description>false (default): The blacklist policy is disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public bool? IsEnable { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
