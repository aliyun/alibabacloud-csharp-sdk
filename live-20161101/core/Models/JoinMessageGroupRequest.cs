// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class JoinMessageGroupRequest : TeaModel {
        /// <summary>
        /// <para>Interactive message application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a494caec-***-695ef345db77</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to broadcast statistics messages. When enabled, statistics information of the message group will be broadcast after joining the message group, and the client can receive and process this message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Broadcast statistics messages.</description></item>
        /// <item><description>false: Do not broadcast statistics messages.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BroadCastStatistics")]
        [Validation(Required=false)]
        public bool? BroadCastStatistics { get; set; }

        /// <summary>
        /// <para>System message diffusion type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): No diffusion.</description></item>
        /// <item><description>1: Diffusion to specified users.</description></item>
        /// <item><description>2: Diffusion to the group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BroadCastType")]
        [Validation(Required=false)]
        public int? BroadCastType { get; set; }

        /// <summary>
        /// <para>The ID of the message group to join. Make sure the GroupId you provide exists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE35-****-T95F</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>User ID, which is customized by the user and must be unique under the AppId. It can contain lowercase letters, numbers, underscores (_), and periods (.). The maximum length is 32 characters. Different users must use different UserIds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
