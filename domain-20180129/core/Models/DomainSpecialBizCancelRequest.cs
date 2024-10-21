// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class DomainSpecialBizCancelRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3666</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
