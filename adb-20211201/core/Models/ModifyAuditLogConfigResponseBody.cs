// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAuditLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDC59E56-BD07-56CA-A05F-B7907DE5C862</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the SQL audit logging status is updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The status is updated.</description></item>
        /// <item><description><b>false</b>: The status failed to be updated.</description></item>
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
