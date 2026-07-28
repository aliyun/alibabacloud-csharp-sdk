// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned by the current task. <b>200</b> indicates that the task is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The timestamp when the IPsec-VPN connection was created. Unit: milliseconds.</para>
        /// <para>The timestamp follows the UNIX format and represents the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1658201810000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The message returned by the current task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88187252-0E26-3C4D-9D1D-32A04454EBBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current task is successfully executed.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successfully executed.</description></item>
        /// <item><description><b>false</b>: Failed to execute.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The IPsec-VPN connection ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-p0wb09rama8qwwgfn****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

    }

}
