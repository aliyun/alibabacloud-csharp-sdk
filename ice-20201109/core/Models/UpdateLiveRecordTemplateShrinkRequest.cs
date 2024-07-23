// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateLiveRecordTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>代表资源名称的资源属性字段</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>录制格式</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public string RecordFormatShrink { get; set; }

        /// <summary>
        /// <para>代表资源一级ID的资源属性字段</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
