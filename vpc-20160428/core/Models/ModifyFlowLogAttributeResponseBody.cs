// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyFlowLogAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7DDDC17-FA06-4AC2-8F35-59D2470FCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The operation is successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
