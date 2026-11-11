// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterPolicyTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the policy route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptbl-44m0p68spvlrqq****</para>
        /// </summary>
        [NameInMap("PolicyTableId")]
        [Validation(Required=false)]
        public string PolicyTableId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BFA6822-240E-4E27-B4C8-AA400EF7474D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
