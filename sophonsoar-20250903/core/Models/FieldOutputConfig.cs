// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class FieldOutputConfig : TeaModel {
        /// <summary>
        /// <para>Field default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.**.*.11</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>Field description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Single IP to be blocked</para>
        /// </summary>
        [NameInMap("FieldDescription")]
        [Validation(Required=false)]
        public string FieldDescription { get; set; }

        /// <summary>
        /// <para>Field example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.<em>.</em>.2</para>
        /// </summary>
        [NameInMap("FieldExample")]
        [Validation(Required=false)]
        public string FieldExample { get; set; }

        /// <summary>
        /// <para>Field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>Field type, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>String</b>: String.</description></item>
        /// <item><description><b>Long</b>: Long integer.</description></item>
        /// <item><description><b>Integer</b>: Integer.</description></item>
        /// <item><description><b>Double</b>: Double.</description></item>
        /// <item><description><b>Boolean</b>: Boolean.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

    }

}
