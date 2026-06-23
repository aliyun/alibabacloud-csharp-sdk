// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class FindBestMatchSecurityStrategyRequest : TeaModel {
        /// <summary>
        /// <para>Control module, used to match the security policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <para>Control sub-module, used to match the security policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        /// <summary>
        /// <para><b>Workspace ID</b>, used to precisely match workspace-level policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
