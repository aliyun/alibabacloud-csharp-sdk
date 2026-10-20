// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FullInstant : TeaModel {
        /// <summary>
        /// <para>The snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("snapshotId")]
        [Validation(Required=false)]
        public long? SnapshotId { get; set; }

        /// <summary>
        /// <para>The tag name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tag</para>
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The location method type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
