// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ElementContent : TeaModel {
        /// <summary>
        /// <para>The content of the element.</para>
        /// <para>If the value of the Type parameter is image or link, this parameter indicates the placeholder text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The time range. The array length is fixed to 2. One element indicates the start time and the other one indicates the end time. Unit: milliseconds.</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public List<long?> TimeRange { get; set; }

        /// <summary>
        /// <para>The type of the element content.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text</description></item>
        /// <item><description>image</description></item>
        /// <item><description>link</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The link to the element content. This parameter takes effect only if the Type parameter is set to image or link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://aliyun.com">http://aliyun.com</a></para>
        /// </summary>
        [NameInMap("URL")]
        [Validation(Required=false)]
        public string URL { get; set; }

    }

}
