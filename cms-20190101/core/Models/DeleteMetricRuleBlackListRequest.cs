// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert blacklist policy. Separate multiple IDs with commas (,). You can specify up to 50 IDs.</para>
        /// <para>For information about how to obtain the ID of an alert blacklist policy, see <a href="https://help.aliyun.com/document_detail/457257.html">DescribeMetricRuleBlackList</a>.</para>
        /// <remarks>
        /// <para>This parameter also supports JSON Array format, for example: <c>[&quot;a9ad2ac2-3ed9-11ed-b878-0242ac12****&quot;,&quot;5cb8a9a4-198f-4651-a353-f8b28788****&quot;]</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9ad2ac2-3ed9-11ed-b878-0242ac12****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
