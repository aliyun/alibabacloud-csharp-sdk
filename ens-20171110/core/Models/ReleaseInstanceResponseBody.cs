// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ReleaseInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance</description></item>
        /// <item><description>eip</description></item>
        /// <item><description>disk</description></item>
        /// <item><description>network</description></item>
        /// <item><description>natgateway</description></item>
        /// <item><description>vswitch</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eip</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
