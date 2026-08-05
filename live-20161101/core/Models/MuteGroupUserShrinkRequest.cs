// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class MuteGroupUserShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VKL3***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The system message broadcast type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: no broadcast.</para>
        /// </description></item>
        /// <item><description><para>1: broadcast to specified users.</para>
        /// </description></item>
        /// <item><description><para>2: broadcast to the group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BroadCastType")]
        [Validation(Required=false)]
        public int? BroadCastType { get; set; }

        /// <summary>
        /// <para>The message group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE35-****-T95F</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The mute duration. Unit: seconds.</para>
        /// <remarks>
        /// <para>If this parameter is not specified or is set to 0, the default mute duration (86400 seconds) is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        /// <summary>
        /// <para>The mute details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MuteUserList")]
        [Validation(Required=false)]
        public string MuteUserListShrink { get; set; }

        /// <summary>
        /// <para>The user ID of the operator.</para>
        /// <remarks>
        /// <para>This parameter is required, and the user must be the creator of the group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
