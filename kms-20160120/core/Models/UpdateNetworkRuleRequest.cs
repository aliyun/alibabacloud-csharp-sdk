// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateNetworkRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description after the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creat by kst-hzz62ee817bvyyr5****</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the access control rule that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>networkrule_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The private IP address or CIDR block after the update. Separate multiple items with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;192.10.XX.XX&quot;,&quot;192.168.XX.XX/24&quot;]</para>
        /// </summary>
        [NameInMap("SourcePrivateIp")]
        [Validation(Required=false)]
        public string SourcePrivateIp { get; set; }

    }

}
