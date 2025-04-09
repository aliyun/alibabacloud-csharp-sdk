// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeResourceByCenterPolicyIdRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l69tQX7yFxx6/4dbooBAOc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-53iyi2aar0nd6****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>app: cloud applications.</description></item>
        /// <item><description>resourceGroup: resource groups.</description></item>
        /// <item><description>desktop: cloud computers.</description></item>
        /// <item><description>desktopGroup: cloud computer shares.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-ia2zw38bi6cm7****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
