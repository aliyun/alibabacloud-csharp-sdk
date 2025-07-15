// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SendMessageToGroupUsersShrinkRequest : TeaModel {
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
        /// <para>The message body. The value is a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

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
        /// <para>The ID of the user who performs the operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>The list of users to receive the message.</para>
        /// </summary>
        [NameInMap("ReceiverIdList")]
        [Validation(Required=false)]
        public string ReceiverIdListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the message requires Alibaba Cloud content moderation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: does not require content moderation.</description></item>
        /// <item><description><b>false</b>: requires content moderation. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipAudit")]
        [Validation(Required=false)]
        public bool? SkipAudit { get; set; }

        /// <summary>
        /// <para>The type of the message. A value that is less than or equal to 10000 specifies a system message. A value that is greater than 10000 specifies a custom message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12000</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
