// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class CreateYikeUserRequest : TeaModel {
        /// <summary>
        /// <para>The nickname of the sub-account user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nick</para>
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <para>The password of the sub-account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The associated projects. Multiple project IDs are supported, separated by commas.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A single user can be added to multiple projects.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1,id2</para>
        /// </summary>
        [NameInMap("ProductionIds")]
        [Validation(Required=false)]
        public string ProductionIds { get; set; }

        /// <summary>
        /// <para>The username prefix of the sub-account. Rules:</para>
        /// <list type="bullet">
        /// <item><description>The prefix can be up to 50 characters in length and must be unique within the workspace.</description></item>
        /// <item><description>The system automatically generates the login name in the following format: {UserNamePrefix}.{Workspace Code}@{Alibaba Cloud UID}.yikeai.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserNamePrefix")]
        [Validation(Required=false)]
        public string UserNamePrefix { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-az2gglkjauwnnhpq</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
