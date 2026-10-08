// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateSecurityIPModeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF1E53AB-5625-49C7-ADF1-FBD0B6640D19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The whitelist mode after the switch, which is the enhanced whitelist mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>safety</para>
        /// </summary>
        [NameInMap("SecurityIPMode")]
        [Validation(Required=false)]
        public string SecurityIPMode { get; set; }

    }

}
