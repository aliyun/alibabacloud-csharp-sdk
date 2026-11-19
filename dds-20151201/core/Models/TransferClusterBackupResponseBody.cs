// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class TransferClusterBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the instance has been switched to cluster backup mode. <b>1</b> indicates that the switch is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AlreadyDone")]
        [Validation(Required=false)]
        public string AlreadyDone { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C4A2494-85C4-45C5-93CF-548DB3375193</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
