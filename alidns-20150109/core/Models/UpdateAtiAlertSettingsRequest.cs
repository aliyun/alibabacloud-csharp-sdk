// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateAtiAlertSettingsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;[{\&quot;NoticeType\&quot;:\&quot;identity_cert_expiring\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;server_cert_expiring\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true}]&quot;</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public string AlertConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;云账号报警联系人\&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
