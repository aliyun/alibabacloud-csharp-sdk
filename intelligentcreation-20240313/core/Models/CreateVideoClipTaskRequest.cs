// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateVideoClipTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1314445556</para>
        /// </summary>
        [NameInMap("aliyunMainId")]
        [Validation(Required=false)]
        public string AliyunMainId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ossKeys")]
        [Validation(Required=false)]
        public List<string> OssKeys { get; set; }

        [NameInMap("requirement")]
        [Validation(Required=false)]
        public string Requirement { get; set; }

    }

}
