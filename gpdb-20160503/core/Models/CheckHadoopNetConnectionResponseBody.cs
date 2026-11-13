// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CheckHadoopNetConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message. If the connection fails, an error message is returned. Otherwise, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection timeout</para>
        /// </summary>
        [NameInMap("ConnectionMessage")]
        [Validation(Required=false)]
        public string ConnectionMessage { get; set; }

        /// <summary>
        /// <para>The connection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Success: The network is connected.</para>
        /// </description></item>
        /// <item><description><para>Failed: The network is disconnected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
