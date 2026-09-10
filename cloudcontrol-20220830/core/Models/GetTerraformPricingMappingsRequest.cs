// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetTerraformPricingMappingsRequest : TeaModel {
        /// <summary>
        /// <para>The request body. The resourceTypes field specifies a list of Terraform resource types, such as alicloud_instance. You can specify a maximum of 200 resource types in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;resourceTypes&quot;: [
        ///     &quot;alicloud_instance&quot;,
        ///     &quot;alicloud_vpc&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
