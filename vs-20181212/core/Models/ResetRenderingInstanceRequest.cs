// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ResetRenderingInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Reset</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("DataPackageId")]
        [Validation(Required=false)]
        public string DataPackageId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
