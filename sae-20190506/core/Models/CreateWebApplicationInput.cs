// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateWebApplicationInput : TeaModel {
        /// <summary>
        /// <para>The name of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sae-app</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my sae app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration on the application revision.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        /// <summary>
        /// <para>The network configurations.</para>
        /// <remarks>
        /// <para> This field is used to configure network for the application.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("WebNetworkConfig")]
        [Validation(Required=false)]
        public WebNetworkConfig WebNetworkConfig { get; set; }

        /// <summary>
        /// <para>The scaling configurations of the applications.</para>
        /// </summary>
        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

        /// <summary>
        /// <para>The traffic configurations of the applications.</para>
        /// </summary>
        [NameInMap("WebTrafficConfig")]
        [Validation(Required=false)]
        public WebTrafficConfig WebTrafficConfig { get; set; }

    }

}
