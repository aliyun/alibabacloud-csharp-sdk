// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditZeroCreditShutdownRequest : TeaModel {
        /// <summary>
        /// <para>UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>Shutdown Policy</br></para>
        /// <list type="bullet">
        /// <item><description><para>immediatelyStop, The instances of the specified End User\&quot;s account will be shutdown immediately once EU triggered the Shutdown Policy.</br></para>
        /// </description></item>
        /// <item><description><para>delayStop, The instances of the specified End User\&quot;s account will be shutdown later, even EU have triggered the Shutdown Policy.</br></para>
        /// </description></item>
        /// <item><description><para>noStop, The instances of the specified End User\&quot;s account will not be shutdown, after EU have triggered the Shutdown Policy.</br></para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ShutdownPolicy")]
        [Validation(Required=false)]
        public string ShutdownPolicy { get; set; }

        /// <summary>
        /// <para>No Change History</para>
        /// 
        /// <b>Example:</b>
        /// <para>1263644979775567</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
