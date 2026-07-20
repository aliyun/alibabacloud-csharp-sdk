// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class RemoveProjectManagerShrinkRequest : TeaModel {
        [NameInMap("org_entities")]
        [Validation(Required=false)]
        public string OrgEntitiesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>projectabc</para>
        /// </summary>
        [NameInMap("out_project_id")]
        [Validation(Required=false)]
        public string OutProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("remove_all")]
        [Validation(Required=false)]
        public bool? RemoveAll { get; set; }

    }

}
