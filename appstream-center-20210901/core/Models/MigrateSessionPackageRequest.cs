// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class MigrateSessionPackageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>p-xxxxxx123x4312367</para>
        /// </summary>
        [NameInMap("DestProjectId")]
        [Validation(Required=false)]
        public string DestProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tp-xxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionPackageId")]
        [Validation(Required=false)]
        public string SessionPackageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>p-xxxxxx123x4312345</para>
        /// </summary>
        [NameInMap("SourceProjectId")]
        [Validation(Required=false)]
        public string SourceProjectId { get; set; }

    }

}
