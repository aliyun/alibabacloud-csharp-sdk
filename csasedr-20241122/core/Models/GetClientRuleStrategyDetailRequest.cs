// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class GetClientRuleStrategyDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the client rule policy. You can obtain the ID from the response of the create operation or the policy list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14808</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
