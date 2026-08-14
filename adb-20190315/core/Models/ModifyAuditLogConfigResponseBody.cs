// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyAuditLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the status of the SQL audit feature is updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The status is updated.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The status failed to be updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpdateSucceed")]
        [Validation(Required=false)]
        public bool? UpdateSucceed { get; set; }

    }

}
