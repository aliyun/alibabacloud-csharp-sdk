// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateVariableRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-baployoyopf22m2r</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>userType</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
