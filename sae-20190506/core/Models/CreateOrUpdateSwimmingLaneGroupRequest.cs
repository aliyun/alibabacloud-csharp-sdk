// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the baseline applications.</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-ea43f648ac46485aa8c894ba1b******</para>
        /// </summary>
        [NameInMap("EntryAppId")]
        [Validation(Required=false)]
        public string EntryAppId { get; set; }

        /// <summary>
        /// <para>The type of the gateway that acts as the application\&quot;s entry point.</para>
        /// <list type="bullet">
        /// <item><description><para><b>apig:</b> cloud-native API gateway</para>
        /// </description></item>
        /// <item><description><para><b>mse:</b> java service gateway</para>
        /// </description></item>
        /// <item><description><para><b>mse-gw:</b> MSE Cloud Native Gateway</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse-gw</para>
        /// </summary>
        [NameInMap("EntryAppType")]
        [Validation(Required=false)]
        public string EntryAppType { get; set; }

        /// <summary>
        /// <para>The ID of the swimming lane group. This parameter is required when you update a swimming lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110272</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the swimming lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The version of the end-to-end canary release. Valid values: 0 and 2. The value 2 is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SwimVersion")]
        [Validation(Required=false)]
        public string SwimVersion { get; set; }

    }

}
