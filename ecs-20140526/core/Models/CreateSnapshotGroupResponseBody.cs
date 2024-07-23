// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01ABBD93-1ABB-4D92-B496-1A3D20EC0697</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot-consistent group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssg-j6ciyh3k52qp7ovm****</para>
        /// </summary>
        [NameInMap("SnapshotGroupId")]
        [Validation(Required=false)]
        public string SnapshotGroupId { get; set; }

    }

}
