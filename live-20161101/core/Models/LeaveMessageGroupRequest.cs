// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class LeaveMessageGroupRequest : TeaModel {
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
        /// <para>Specifies whether to broadcast statistical messages. If you set the value to true, statistical messages of the message group are broadcasted after the users join the message group. The client can receive and process these messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: broadcasts statistical messages.</description></item>
        /// <item><description>false: does not broadcast statistical messages.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BroadCastStatistics")]
        [Validation(Required=false)]
        public bool? BroadCastStatistics { get; set; }

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
        /// <para>The ID of the user. Each user has a unique ID in the application.</para>
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
