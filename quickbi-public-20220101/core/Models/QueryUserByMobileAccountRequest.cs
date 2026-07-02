// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserByMobileAccountRequest : TeaModel {
        /// <summary>
        /// <para>The bound mobile type.</para>
        /// <list type="bullet">
        /// <item><description>DingTalk: ding</description></item>
        /// <item><description>WeCom: corp_weixin</description></item>
        /// <item><description>Lark: feishu.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding</para>
        /// </summary>
        [NameInMap("MobileType")]
        [Validation(Required=false)]
        public string MobileType { get; set; }

        /// <summary>
        /// <para>The bound mobile user ID.</para>
        /// <list type="bullet">
        /// <item><description>DingTalk: The unionId of the DingTalk account.</description></item>
        /// <item><description>WeCom: The userId of the WeCom account.</description></item>
        /// <item><description>Lark: The userId of the Lark account.<remarks>
        /// <para>Notice: The mobileUserId must be obtained by calling the relevant DingTalk, WeCom, or Lark API operations..</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
