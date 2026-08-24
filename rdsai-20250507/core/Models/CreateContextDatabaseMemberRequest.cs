// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateContextDatabaseMemberRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to issue the first API key when the member is created. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GenerateInitialKey")]
        [Validation(Required=false)]
        public bool? GenerateInitialKey { get; set; }

        /// <summary>
        /// <para>The name of the first API key. This parameter takes effect only when GenerateInitialKey is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-key</para>
        /// </summary>
        [NameInMap("InitialKeyName")]
        [Validation(Required=false)]
        public string InitialKeyName { get; set; }

        /// <summary>
        /// <para>The member name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>The member role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>owner</description></item>
        /// <item><description>admin</description></item>
        /// <item><description>member</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>member</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
