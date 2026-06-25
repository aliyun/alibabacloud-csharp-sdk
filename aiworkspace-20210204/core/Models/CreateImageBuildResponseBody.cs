// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateImageBuildResponseBody : TeaModel {
        /// <summary>
        /// <para>The image build ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>build-****ks92</para>
        /// </summary>
        [NameInMap("ImageBuildId")]
        [Validation(Required=false)]
        public string ImageBuildId { get; set; }

        /// <summary>
        /// <para>The build task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-****ks92</para>
        /// </summary>
        [NameInMap("ImageBuildJobId")]
        [Validation(Required=false)]
        public string ImageBuildJobId { get; set; }

    }

}
