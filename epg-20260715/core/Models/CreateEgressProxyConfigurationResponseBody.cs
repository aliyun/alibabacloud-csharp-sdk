// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the egress proxy configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-uf609a6a8fdf9f4d****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C79118A9-CA6D-5359-B53E-111BE8A03DCF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
