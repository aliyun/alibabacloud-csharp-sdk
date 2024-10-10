// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateWebApplicationInput : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sae-app</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my sae app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        [NameInMap("WebNetworkConfig")]
        [Validation(Required=false)]
        public WebNetworkConfig WebNetworkConfig { get; set; }

        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

        [NameInMap("WebTrafficConfig")]
        [Validation(Required=false)]
        public WebTrafficConfig WebTrafficConfig { get; set; }

    }

}
