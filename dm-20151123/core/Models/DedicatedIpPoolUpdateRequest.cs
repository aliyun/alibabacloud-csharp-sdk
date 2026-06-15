// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpPoolUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the purchased IP instances. Separate multiple IDs with commas. Obtain these IDs from the response of the DedicatedIpNonePoolList operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx,xxx</para>
        /// </summary>
        [NameInMap("BuyResourceIds")]
        [Validation(Required=false)]
        public string BuyResourceIds { get; set; }

        /// <summary>
        /// <para>The ID of the IP pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to change the associated IP addresses. Set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpdateResource")]
        [Validation(Required=false)]
        public bool? UpdateResource { get; set; }

    }

}
