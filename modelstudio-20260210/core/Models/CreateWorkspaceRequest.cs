// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("serviceSite")]
        [Validation(Required=false)]
        public string ServiceSite { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace_test</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
