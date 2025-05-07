// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingSolutionFramework20230810.Models
{
    public class SendOpsMessageToTerminalRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("MessageBody")]
        [Validation(Required=false)]
        public string MessageBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("OfficeRegionId")]
        [Validation(Required=false)]
        public string OfficeRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>reboot</para>
        /// </summary>
        [NameInMap("OpsAction")]
        [Validation(Required=false)]
        public string OpsAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAAAAAAAA</para>
        /// </summary>
        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WaitForAck")]
        [Validation(Required=false)]
        public bool? WaitForAck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WaitForMsg")]
        [Validation(Required=false)]
        public bool? WaitForMsg { get; set; }

    }

}
