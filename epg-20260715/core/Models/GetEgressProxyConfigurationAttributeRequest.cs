// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class GetEgressProxyConfigurationAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the egress proxy configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-hn302f6a9a284c4f****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

    }

}
