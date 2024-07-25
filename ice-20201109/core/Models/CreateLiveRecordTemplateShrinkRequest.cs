// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// 代表资源名称的资源属性字段
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 录制格式
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public string RecordFormatShrink { get; set; }

    }

}
