// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsPathField : TeaModel {
        /// <summary>
        /// <para>The secondary category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversation</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The field description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户输入的问题内容</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The log key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>question</para>
        /// </summary>
        [NameInMap("fieldKey")]
        [Validation(Required=false)]
        public string FieldKey { get; set; }

        /// <summary>
        /// <para>The request or response direction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request</para>
        /// </summary>
        [NameInMap("io")]
        [Validation(Required=false)]
        public string Io { get; set; }

        /// <summary>
        /// <para>The corresponding JSON path (GJSON syntax).</para>
        /// 
        /// <b>Example:</b>
        /// <para>messages.#.content</para>
        /// </summary>
        [NameInMap("jsonPath")]
        [Validation(Required=false)]
        public string JsonPath { get; set; }

        /// <summary>
        /// <para>The display name of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>问题内容</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether collection is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("recordEnabled")]
        [Validation(Required=false)]
        public bool? RecordEnabled { get; set; }

        /// <summary>
        /// <para>The rule used for streaming response extraction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>append: appends content</description></item>
        /// <item><description>first: retrieves the first value</description></item>
        /// <item><description>replace: retrieves the last value</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>append</para>
        /// </summary>
        [NameInMap("rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_body</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
