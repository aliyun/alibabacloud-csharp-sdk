// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class AcceptPushRequest : TeaModel {
        /// <summary>
        /// <para>实名认证通过的模板，域名过户时用于WHOIS信息变更</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13862458</para>
        /// </summary>
        [NameInMap("ContactTemplateId")]
        [Validation(Required=false)]
        public long? ContactTemplateId { get; set; }

        /// <summary>
        /// <para>Push编号</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>push_20250101_abc123</para>
        /// </summary>
        [NameInMap("PushNo")]
        [Validation(Required=false)]
        public string PushNo { get; set; }

    }

}
