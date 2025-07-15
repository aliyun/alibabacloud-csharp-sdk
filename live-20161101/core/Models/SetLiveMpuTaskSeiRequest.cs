// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveMpuTaskSeiRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para> The ID can be up to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VKL3***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The custom SEI.</para>
        /// <remarks>
        /// <para> The value is a JSON string that can be up to 4,096 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;myroom&quot;}</para>
        /// </summary>
        [NameInMap("CustomSei")]
        [Validation(Required=false)]
        public string CustomSei { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <remarks>
        /// <para> The ID can be up to 55 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AL-4bce036dd90277c50705b0599wgfffc7</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
