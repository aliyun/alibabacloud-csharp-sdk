// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateMessageChatTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19de81b3b3d94abda22******</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The validity period. Unit: seconds. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public int? Expire { get; set; }

        /// <summary>
        /// <para>The role. A value of admin indicates that the user can perform management operations. This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The ID of the user to sign in. It can be up to 64 characters in length and can contain only letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YOURUSERID</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
