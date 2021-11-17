// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class StopInstanceRequest : TeaModel {
        /// <summary>
        /// 是否保存镜像后停止
        /// </summary>
        [NameInMap("SaveImage")]
        [Validation(Required=false)]
        public bool? SaveImage { get; set; }

    }

}
