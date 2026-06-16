// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ExportMaterialFileRequest : TeaModel {
        /// <summary>
        /// <para>The business instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The list of file IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

    }

}
