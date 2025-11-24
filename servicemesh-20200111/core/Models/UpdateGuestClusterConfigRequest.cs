// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateGuestClusterConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c42186268a27f475c975e5667bb66****</para>
        /// </summary>
        [NameInMap("GuestClusterId")]
        [Validation(Required=false)]
        public string GuestClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SMCEnabled")]
        [Validation(Required=false)]
        public bool? SMCEnabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
