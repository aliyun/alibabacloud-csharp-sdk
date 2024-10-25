// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifySnapshotAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the snapshot. The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp199lyny9bb47pa****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The name of the snapshot. The name must be 2 to 128 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>The name cannot start with <b>auto</b> because snapshots whose names start with auto are recognized as automatic snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSnapshotName</para>
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

    }

}
