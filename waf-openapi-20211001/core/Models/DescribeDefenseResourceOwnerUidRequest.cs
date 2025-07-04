// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceOwnerUidRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn********60f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.com-waf,b.com-waf</para>
        /// </summary>
        [NameInMap("ResourceNames")]
        [Validation(Required=false)]
        public string ResourceNames { get; set; }

    }

}
