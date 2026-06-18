// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineRuntimeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A return value of &quot;Success&quot; indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Hotline runtime information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;buId&quot;:905,&quot;phoneToken&quot;:&quot;roESVzzgD1ytmG0W6nMkWinI6fbpKovm14fBhA0NsYPyi/srX/G0SvNB2z96AYiqy1vxQHiaFOdZSxtsAubdgr2kjs2yas7COO5dukQpsOLq9iNI4U6sKlcvaBi8xsyUr/hyqCdTVZDcYCOq0lH6eeNIQK/f7/gWqIw****=&quot;,&quot;isNeedWorkShift&quot;:false,&quot;servicerId&quot;:741018,&quot;accConfigUrl&quot;:&quot;pre-acc-cs-public.alibaba-inc.com&quot;,&quot;agentBasicCode&quot;:&quot;AgentCheckout&quot;,&quot;startWorkToReady&quot;:true,&quot;servicerDn&quot;:&quot;2000000001904123&quot;,&quot;isMaster&quot;:&quot;1&quot;,&quot;tenantId&quot;:2001,&quot;depId&quot;:1139139,&quot;accTenantId&quot;:2001,&quot;phoneData&quot;:&quot;{\&quot;timeStamp\&quot;:164240****,\&quot;expireTime\&quot;:164257****,\&quot;dn\&quot;:\&quot;200000000190****\&quot;,\&quot;source\&quot;:\&quot;xspace\&quot;,\&quot;serviceId\&quot;:741018}&quot;,&quot;agentBasicDesc&quot;:&quot;坐席签出状态&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
