// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTranscodeParamsRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("app")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pushdomain")]
        [Validation(Required=false)]
        public string Pushdomain { get; set; }

        [NameInMap("template_name")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
