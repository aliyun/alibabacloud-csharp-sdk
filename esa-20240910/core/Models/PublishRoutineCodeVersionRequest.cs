// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PublishRoutineCodeVersionRequest : TeaModel {
        [NameInMap("CanaryAreaList")]
        [Validation(Required=false)]
        public List<string> CanaryAreaList { get; set; }

        [NameInMap("CanaryCodeVersion")]
        [Validation(Required=false)]
        public string CanaryCodeVersion { get; set; }

        [NameInMap("CodeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PublishRoutineCodeVersion</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
