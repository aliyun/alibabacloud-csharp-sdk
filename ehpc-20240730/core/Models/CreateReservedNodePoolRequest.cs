// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateReservedNodePoolRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ed</para>
        /// </summary>
        [NameInMap("HostPostfix")]
        [Validation(Required=false)]
        public string HostPostfix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud</para>
        /// </summary>
        [NameInMap("HostPrefix")]
        [Validation(Required=false)]
        public string HostPrefix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-bp1lfcjbfb099rrjn****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
