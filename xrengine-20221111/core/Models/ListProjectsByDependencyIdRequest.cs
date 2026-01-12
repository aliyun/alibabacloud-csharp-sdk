// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class ListProjectsByDependencyIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DependencyProjectId")]
        [Validation(Required=false)]
        public long? DependencyProjectId { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("MapUuid")]
        [Validation(Required=false)]
        public string MapUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WithDataset")]
        [Validation(Required=false)]
        public bool? WithDataset { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WithSource")]
        [Validation(Required=false)]
        public bool? WithSource { get; set; }

    }

}
