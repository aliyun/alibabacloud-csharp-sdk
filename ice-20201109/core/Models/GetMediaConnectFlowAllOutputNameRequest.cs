// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowAllOutputNameRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0381f478-7d53-4076-9d5f-27680a6f73e7</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

    }

}
