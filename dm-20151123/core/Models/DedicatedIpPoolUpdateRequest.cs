// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpPoolUpdateRequest : TeaModel {
        /// <summary>
        /// <para>Purchased IP instance IDs, separated by commas; sourced from the DedicatedIpNonePoolList API\&quot;s returned IP purchase instance IDs</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx,xxx</para>
        /// </summary>
        [NameInMap("BuyResourceIds")]
        [Validation(Required=false)]
        public string BuyResourceIds { get; set; }

        /// <summary>
        /// <para>IP pool ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Whether to change the associated IP, enter true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpdateResource")]
        [Validation(Required=false)]
        public bool? UpdateResource { get; set; }

    }

}
