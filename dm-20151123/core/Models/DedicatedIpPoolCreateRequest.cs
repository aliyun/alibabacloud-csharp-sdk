// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpPoolCreateRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the purchased IP instances. Separate multiple IDs with commas (,). You can obtain the instance IDs from the response of the DedicatedIpNonePoolList operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx,xxx</para>
        /// </summary>
        [NameInMap("BuyResourceIds")]
        [Validation(Required=false)]
        public string BuyResourceIds { get; set; }

        /// <summary>
        /// <para>The name of the IP pool. The name must be 1 to 50 characters in length. It can contain letters, digits, underscores (_), and hyphens (-). The name cannot be changed after the IP pool is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
