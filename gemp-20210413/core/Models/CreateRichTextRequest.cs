// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateRichTextRequest : TeaModel {
        /// <summary>
        /// 资源id
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [NameInMap("richText")]
        [Validation(Required=false)]
        public string RichText { get; set; }

    }

}
