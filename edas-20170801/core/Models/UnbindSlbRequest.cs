// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UnbindSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c627c157-560d-********************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the configured listeners. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: removes the configured listeners.</description></item>
        /// <item><description>false: does not remove the configured listeners.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteListener")]
        [Validation(Required=false)]
        public string DeleteListener { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz9vo49****************</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The network type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: Internet-facing SLB instance</description></item>
        /// <item><description><b>intranet</b>: internal-facing SLB instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
