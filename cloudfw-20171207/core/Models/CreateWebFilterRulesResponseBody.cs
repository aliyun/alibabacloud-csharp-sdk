// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateWebFilterRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of IDs of the newly created web filtering rules. The order of the IDs corresponds to the order of the input Rules parameter.</para>
        /// </summary>
        [NameInMap("WebFilterRuleIds")]
        [Validation(Required=false)]
        public List<string> WebFilterRuleIds { get; set; }

    }

}
