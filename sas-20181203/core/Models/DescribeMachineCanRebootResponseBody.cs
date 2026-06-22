// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMachineCanRebootResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the server can be restarted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The server can be restarted.</description></item>
        /// <item><description><b>false</b>: The server cannot be restarted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanReboot")]
        [Validation(Required=false)]
        public bool? CanReboot { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
