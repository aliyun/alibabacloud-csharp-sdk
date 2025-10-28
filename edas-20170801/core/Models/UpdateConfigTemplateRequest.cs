// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateConfigTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The content of the configuration template. The value must be in the format that is specified by the Format parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;william&quot;,&quot;age&quot;:18}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The description of the configuration template. The description can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test configuration template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The data format of the configuration template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>JSON: JSON format</description></item>
        /// <item><description>XML: XML format</description></item>
        /// <item><description>YAML: YAML format</description></item>
        /// <item><description>Properties: .properties format</description></item>
        /// <item><description>KeyValue: key-value pairs</description></item>
        /// <item><description>Custom: custom format</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The ID of the configuration template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the configuration template. The name can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>configtmpl1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
