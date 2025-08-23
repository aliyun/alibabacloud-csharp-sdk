// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GetFileContentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://default/aimiaobi-service-prod/aimiaobi/temp/1154600634854327_10045847/300469535473178749_300469535473178749_ee11508152b74137ac5747a6f632256e.docx</para>
        /// </summary>
        [NameInMap("fileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

    }

}
