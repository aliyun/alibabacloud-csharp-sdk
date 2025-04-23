// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class StartVisualServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the VNC Remote visualization service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Service started</description></item>
        /// <item><description>Service stopped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Service started</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE6880</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
