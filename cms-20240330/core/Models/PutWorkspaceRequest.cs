// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PutWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Description of the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Display name of the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Name of the Log Service project</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-project-test-001</para>
        /// </summary>
        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

    }

}
