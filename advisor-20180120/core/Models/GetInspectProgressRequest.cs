// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class GetInspectProgressRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>14********37</para>
        /// </summary>
        [NameInMap("AssumeAliyunId")]
        [Validation(Required=false)]
        public long? AssumeAliyunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95***135</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
