// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateRCNodePoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIdSets")]
        [Validation(Required=false)]
        public List<string> InstanceIdSets { get; set; }

        /// <summary>
        /// <para>The node pool ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np31da1b38983f4511b490fc62108a****</para>
        /// </summary>
        [NameInMap("NodePoolId")]
        [Validation(Required=false)]
        public string NodePoolId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50357661918****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08A3B71B-FE08-4B03-974F-CC7EA6DB1828</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
