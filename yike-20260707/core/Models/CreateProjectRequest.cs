// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The name of the project. The name can be up to 50 characters in length and cannot contain single quotation marks, semicolons, less than signs, greater than signs, equal signs, vertical lines, or parentheses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product Demo</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the project belongs. If this parameter is not specified, the default workspace of the current account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws_zna577pdximv***</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
