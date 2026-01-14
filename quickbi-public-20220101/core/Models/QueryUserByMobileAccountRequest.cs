// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserByMobileAccountRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding</para>
        /// </summary>
        [NameInMap("MobileType")]
        [Validation(Required=false)]
        public string MobileType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sasda</para>
        /// </summary>
        [NameInMap("MobileUserId")]
        [Validation(Required=false)]
        public string MobileUserId { get; set; }

    }

}
