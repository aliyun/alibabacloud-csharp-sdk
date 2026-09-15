// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateMaintainWindowRequest : TeaModel {
        /// <summary>
        /// <para>The request body. This parameter is required by the backend. Pass in a complete MaintainWindowForModify configuration object.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public MaintainWindowForModify Body { get; set; }

        /// <summary>
        /// <para>The workspace name. This parameter is required by the backend and is used to isolate silence policy resources across different business spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
