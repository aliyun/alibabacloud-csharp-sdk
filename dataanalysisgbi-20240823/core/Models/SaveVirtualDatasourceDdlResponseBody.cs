// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class SaveVirtualDatasourceDdlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoAuth</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NoAuth</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72ABCA5B-1E93-55D3-8A61-6D8A03CC5C8B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
