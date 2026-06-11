// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateDataAgentSpaceInfoRequest : TeaModel {
        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable session sharing for the workspace. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSessionShareEnabled")]
        [Validation(Required=false)]
        public bool? IsSessionShareEnabled { get; set; }

        /// <summary>
        /// <para>The new description for the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>space for test new</para>
        /// </summary>
        [NameInMap("WorkspaceDesc")]
        [Validation(Required=false)]
        public string WorkspaceDesc { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20923*****7291</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The new name for the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yunqitest_v2</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
