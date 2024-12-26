// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition that is used to query instances. If you do not configure this parameter, all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-7e22ody****</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Valid values: 1 to 100000000.</para>
        /// <para>If you set this parameter to a value smaller than 1, the system uses 1 as the value. If you set this parameter to a value greater than 100000000, the system uses 100000000 as the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Value values: 10 to 200.</para>
        /// <para>If you set this parameter to a value smaller than 10, the system uses 10 as the value. If you set this parameter to a value greater than 200, the system uses 200 as the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmx7caj******</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The primary edition of the instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: Standard Edition</description></item>
        /// <item><description>ultimate: Enterprise Platinum Edition</description></item>
        /// <item><description>professional: Professional Edition</description></item>
        /// </list>
        /// </summary>
        [NameInMap("seriesCodes")]
        [Validation(Required=false)]
        public List<string> SeriesCodes { get; set; }

        /// <summary>
        /// <para>The storage encryption key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("storageSecretKey")]
        [Validation(Required=false)]
        public string StorageSecretKey { get; set; }

        /// <summary>
        /// <para>The tags that are used to filter instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;: &quot;rmq-test&quot;, &quot;value&quot;: &quot;test&quot;}]</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
