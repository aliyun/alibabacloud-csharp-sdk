// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GenerateAlgorithmCustomizationScriptResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss:xxxx</para>
        /// </summary>
        [NameInMap("OssAddress")]
        [Validation(Required=false)]
        public string OssAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6CF1E160-3F36-5E73-A170-C75504F05BBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
