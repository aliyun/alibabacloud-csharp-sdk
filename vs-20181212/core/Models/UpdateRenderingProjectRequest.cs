// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateRenderingProjectRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>idata_content</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SessionAttribs")]
        [Validation(Required=false)]
        public UpdateRenderingProjectRequestSessionAttribs SessionAttribs { get; set; }
        public class UpdateRenderingProjectRequestSessionAttribs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Async</para>
            /// </summary>
            [NameInMap("StartMode")]
            [Validation(Required=false)]
            public string StartMode { get; set; }

        }

    }

}
