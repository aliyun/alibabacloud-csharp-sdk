// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class OpenStructDlfTagDto : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("snapshotId")]
        [Validation(Required=false)]
        public long? SnapshotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>milvus-auto-20260101</para>
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1711334400000</para>
        /// </summary>
        [NameInMap("timeMillis")]
        [Validation(Required=false)]
        public long? TimeMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("totalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
