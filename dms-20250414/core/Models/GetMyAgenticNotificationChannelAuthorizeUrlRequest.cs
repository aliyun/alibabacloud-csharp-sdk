// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetMyAgenticNotificationChannelAuthorizeUrlRequest : TeaModel {
        /// <summary>
        /// <para>The notification channel type. Currently, only FEISHU (the Chinese version of Lark) is supported. Specifying other values results in a parameter error.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

    }

}
