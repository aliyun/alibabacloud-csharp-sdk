// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the description for the configuration items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en_US</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to obtain the specific configuration items of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withConfig")]
        [Validation(Required=false)]
        public bool? WithConfig { get; set; }

    }

}
