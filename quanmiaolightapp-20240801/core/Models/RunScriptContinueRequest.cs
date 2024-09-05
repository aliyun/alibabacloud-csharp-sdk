// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunScriptContinueRequest : TeaModel {
        [NameInMap("scriptSummary")]
        [Validation(Required=false)]
        public string ScriptSummary { get; set; }

        [NameInMap("scriptTypeKeyword")]
        [Validation(Required=false)]
        public string ScriptTypeKeyword { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userProvidedContent")]
        [Validation(Required=false)]
        public string UserProvidedContent { get; set; }

    }

}
