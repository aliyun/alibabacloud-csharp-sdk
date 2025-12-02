// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the baseline application.</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIdsShrink { get; set; }

        /// <summary>
        /// <para>The unique ID of the corresponding gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_ingresspost-cn-axc49******</para>
        /// </summary>
        [NameInMap("EntryAppId")]
        [Validation(Required=false)]
        public string EntryAppId { get; set; }

        /// <summary>
        /// <para>The application entry type (gateway type).</para>
        /// <list type="bullet">
        /// <item><description><b>apig:</b> cloud-native API Gateway</description></item>
        /// <item><description><b>mse:</b> Java Services Gateway</description></item>
        /// <item><description><b>mse-gw:</b> MSE cloud-native Gateway</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse-gw</para>
        /// </summary>
        [NameInMap("EntryAppType")]
        [Validation(Required=false)]
        public string EntryAppType { get; set; }

        /// <summary>
        /// <para>The ID of the lane group. This is required when you update a lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2047</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The ID of a namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The end-to-end grayscale version. Valid values: 0 and 2 (recommended).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SwimVersion")]
        [Validation(Required=false)]
        public string SwimVersion { get; set; }

    }

}
