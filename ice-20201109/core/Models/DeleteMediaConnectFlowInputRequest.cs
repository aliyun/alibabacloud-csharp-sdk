// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteMediaConnectFlowInputRequest : TeaModel {
        /// <summary>
        /// <para>The flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0381f478-7d53-4076-9d5f-27680a6f73e7</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>Input name. Required when primary/standby input is enabled for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input</para>
        /// </summary>
        [NameInMap("InputName")]
        [Validation(Required=false)]
        public string InputName { get; set; }

    }

}
