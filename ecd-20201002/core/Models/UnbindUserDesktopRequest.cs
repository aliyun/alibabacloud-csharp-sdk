// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class UnbindUserDesktopRequest : TeaModel {
        /// <summary>
        /// <para>The client ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58f96f67-7944-4f97-9342-****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced unbinding.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Even when end users connect to cloud computers, the forced unbinding is still enforced.</description></item>
        /// <item><description>false: Forced unbinding is only enforced when end users are disconnected from cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The logon token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v12307f5e0****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b053331-dc98-43d8-b247-****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The cloud computer ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ud-sdfs****</para>
        /// </summary>
        [NameInMap("UserDesktopId")]
        [Validation(Required=false)]
        public string UserDesktopId { get; set; }

    }

}
