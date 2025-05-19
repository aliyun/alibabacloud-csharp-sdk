// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneGroupShrinkRequest : TeaModel {
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mse_ingresspost-cn-axc49******</para>
        /// </summary>
        [NameInMap("EntryAppId")]
        [Validation(Required=false)]
        public string EntryAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mse-gw</para>
        /// </summary>
        [NameInMap("EntryAppType")]
        [Validation(Required=false)]
        public string EntryAppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2047</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mse-test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SwimVersion")]
        [Validation(Required=false)]
        public string SwimVersion { get; set; }

    }

}
