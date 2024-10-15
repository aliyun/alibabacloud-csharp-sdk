// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotInfoListRequest : TeaModel {
        /// <summary>
        /// <para>The review state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CONFIGURABLE</b></description></item>
        /// <item><description><b>AUDITING</b></description></item>
        /// <item><description><b>AUDITPASS</b></description></item>
        /// <item><description><b>AUDITFAIL</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUDITING</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
