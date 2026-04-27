// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentLogoutRequest : TeaModel {
        /// <summary>
        /// <para>座席工号；取值3-10位正整数</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>是否忽略重复下线报错；取值：0:不忽略 1:忽略 默认为0，不忽略</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IgnoreOffline")]
        [Validation(Required=false)]
        public long? IgnoreOffline { get; set; }

        /// <summary>
        /// <para>是否给座席发生kickout事件；取值： 0:不发送， 1:发送 默认为1，发送</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsKickout")]
        [Validation(Required=false)]
        public long? IsKickout { get; set; }

        /// <summary>
        /// <para>取值： 0:不解除绑定电话， 1:解除绑定电话 默认为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RemoveBinding")]
        [Validation(Required=false)]
        public long? RemoveBinding { get; set; }

    }

}
