// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupCorpTokenRequest : TeaModel {
        /// <summary>
        /// <para>The API call secret key of the application. For information about how to obtain it, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=4667763">Application Basic Information - Application Credentials</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZzljczY5d********xlcjVTKnVoZS0</para>
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>The enterprise proxy ID, which is used to establish the bindingrelationship between the enterprise and the application. For information about how to obtain it, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=4667765">Callable Enterprises</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open12********i07v10wDzRSK9w00</para>
        /// </summary>
        [NameInMap("corp_id")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>The subsidiary enterprise ID.</para>
        /// <list type="bullet">
        /// <item><description><b>View permission:</b> Only enterprise administrators have view permission.</description></item>
        /// <item><description><b>View path:</b> Log on to the <a href="https://admin.alibtrip.com/home/BtripIndex?s=api#/home">Enterprise Management Console</a> as an <b>enterprise administrator</b> &gt; Parent-Child Account Management &gt; Account Management &gt; Child Account Management &gt; Company ID.
        /// <img src="https://intranetproxy.alipay.com/skylark/lark/0/2024/png/298807/1710403874851-5fb613cb-ced8-4b99-9151-486df29ba6c6.png" alt="Image"></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>btrip********cs286734u_mow6q</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

    }

}
