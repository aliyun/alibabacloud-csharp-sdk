// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// 资源名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public byte[] Name { get; set; }

        /// <summary>
        /// 录制格式
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public string RecordFormatShrink { get; set; }

    }

}
