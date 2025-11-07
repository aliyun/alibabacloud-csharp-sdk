// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetGitRepositoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FASTJSON 2.0.x has been released, faster and more secure, recommend you upgrade.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://github.com/alibaba/fastjson">https://github.com/alibaba/fastjson</a></para>
        /// </summary>
        [NameInMap("HtmlUrl")]
        [Validation(Required=false)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsPrivate")]
        [Validation(Required=false)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13B71887-D215-53B5-8818-4D3190604B26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
