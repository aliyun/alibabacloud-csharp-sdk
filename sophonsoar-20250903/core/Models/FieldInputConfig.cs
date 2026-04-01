// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class FieldInputConfig : TeaModel {
        /// <summary>
        /// <para>Is the field arrayed? Possible values are:</para>
        /// <list type="bullet">
        /// <item><description>true: Arrayed.</description></item>
        /// <item><description>false: Not Arrayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Arrayed")]
        [Validation(Required=false)]
        public bool? Arrayed { get; set; }

        /// <summary>
        /// <para>Field default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>Field check regex.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[a-zA-Z0-9\u4e00-\u9fa5_-]{2,128}</para>
        /// </summary>
        [NameInMap("FieldCheckRegex")]
        [Validation(Required=false)]
        public string FieldCheckRegex { get; set; }

        /// <summary>
        /// <para>Field types, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: Normal type.</description></item>
        /// <item><description><b>custom</b>: Complex type; in this mode, FieldConfigs can be configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("FieldClass")]
        [Validation(Required=false)]
        public string FieldClass { get; set; }

        /// <summary>
        /// <para>Supports configuring nested input parameters in complex-type scenarios.</para>
        /// </summary>
        [NameInMap("FieldConfigs")]
        [Validation(Required=false)]
        public List<FieldInputConfig> FieldConfigs { get; set; }

        /// <summary>
        /// <para>Field description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app name</para>
        /// </summary>
        [NameInMap("FieldDescription")]
        [Validation(Required=false)]
        public string FieldDescription { get; set; }

        /// <summary>
        /// <para>Field example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FieldExample")]
        [Validation(Required=false)]
        public string FieldExample { get; set; }

        /// <summary>
        /// <para>Field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appName</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>Field path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx.appName</para>
        /// </summary>
        [NameInMap("FieldPath")]
        [Validation(Required=false)]
        public string FieldPath { get; set; }

        /// <summary>
        /// <para>The field type. The value is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>String</b>: String.</description></item>
        /// <item><description><b>Long</b>: Long integer.</description></item>
        /// <item><description><b>Integer</b>: Integer.</description></item>
        /// <item><description><b>Double</b>: Floating-point type.</description></item>
        /// <item><description><b>Boolean</b>: Boolean.</description></item>
        /// <item><description><b>ip</b>: The IP entity.</description></item>
        /// <item><description><b>file</b>: file entity.</description></item>
        /// <item><description><b>process</b>: process entity.</description></item>
        /// <item><description><b>incident</b>: event entity.</description></item>
        /// <item><description><b>alert</b>: alert entity.</description></item>
        /// <item><description><b>host</b>: host entity.</description></item>
        /// <item><description><b>domain</b>: The domain name entity.</description></item>
        /// <item><description><b>container</b>: container entity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// <para>Is the field mandatory? Possible values are:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Required.</description></item>
        /// <item><description><b>false</b>: Optional.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

    }

}
