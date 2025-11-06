// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateImageBuildResponseBody : TeaModel {
        /// <summary>
        /// <para>代表资源一级ID的资源属性字段</para>
        /// 
        /// <b>Example:</b>
        /// <para>build-****ks92</para>
        /// </summary>
        [NameInMap("ImageBuildId")]
        [Validation(Required=false)]
        public string ImageBuildId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-****ks92</para>
        /// </summary>
        [NameInMap("ImageBuildJobId")]
        [Validation(Required=false)]
        public string ImageBuildJobId { get; set; }

    }

}
