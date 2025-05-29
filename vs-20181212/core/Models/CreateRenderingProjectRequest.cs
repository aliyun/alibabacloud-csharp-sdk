// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingProjectRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>du_merchant_d</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SessionAttribs")]
        [Validation(Required=false)]
        public CreateRenderingProjectRequestSessionAttribs SessionAttribs { get; set; }
        public class CreateRenderingProjectRequestSessionAttribs : TeaModel {
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
