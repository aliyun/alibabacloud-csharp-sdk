// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The service deployment scope (the deployment scope for services that depend on GPU resources, such as inference, training, and deployment). The Beijing and Singapore regions are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("serviceSite")]
        [Validation(Required=false)]
        public string ServiceSite { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
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
