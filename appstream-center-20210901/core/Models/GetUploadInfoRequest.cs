// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetUploadInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business region where the file is uploaded. If this parameter is not specified, the default OSS region configured for the service is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The type of the file to upload. Currently, only TASK is supported, which indicates an image task file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TASK</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

    }

}
