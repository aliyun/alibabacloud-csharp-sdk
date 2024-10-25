// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// <list type="bullet">
        /// <item><description>Pages start from page 1.</description></item>
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 50.</description></item>
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DocTest</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
