// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeUserTagKeysRequest : TeaModel {
        /// <summary>
        /// <para>Number of items per page in paginated queries. The maximum value is 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If no value is set or the set value is less than 10, the default is 10.</para>
        /// </description></item>
        /// <item><description><para>If the set value is greater than 100, the default is 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned by this call (Token).</para>
        /// 
        /// <b>Example:</b>
        /// <para>f07b150eadfa1d7a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the resource belongs. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tagKey for filtering the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tagKey</para>
        /// </summary>
        [NameInMap("TagFilterKey")]
        [Validation(Required=false)]
        public string TagFilterKey { get; set; }

    }

}
