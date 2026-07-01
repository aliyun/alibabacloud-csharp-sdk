// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateYikeUserRequest : TeaModel {
        /// <summary>
        /// <para>The user\&quot;s nickname.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nick</para>
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <para>The user\&quot;s password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The IDs of productions to add the user to. You can specify multiple IDs separated by commas.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A user can be added to multiple productions.</description></item>
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
        /// <para>The user name prefix for the sub-account. The prefix must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The prefix can be up to 50 characters long and must be unique within the workspace.</para>
        /// </description></item>
        /// <item><description><para>The system automatically generates a user login name in the format: {UserNamePrefix}.{WorkspaceCode}@{AlibabaCloudUID}.yikeai.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test.xxx@xxx.yikeai">test.xxx@xxx.yikeai</a></para>
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
