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
        /// <para>The mode in which system messages are broadcasted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: specifies that system messages are not broadcasted. This is the default value.</description></item>
        /// <item><description>1: specifies that system messages are broadcasted to specified users.</description></item>
        /// <item><description>2: specifies that system messages are broadcasted to the message group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BroadCastType")]
        [Validation(Required=false)]
        public int? BroadCastType { get; set; }

        /// <summary>
        /// <para>The ID of the message group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE35-****-T95F</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The duration of the mute. Unit: seconds.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter or set the value to 0, the default duration of 86,400 seconds is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        /// <summary>
        /// <para>Details about the mute.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MuteUserList")]
        [Validation(Required=false)]
        public string MuteUserListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
