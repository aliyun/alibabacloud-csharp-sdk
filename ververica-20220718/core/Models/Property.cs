// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Property : TeaModel {
        /// <summary>
        /// <para>The default value of the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userA</para>
        /// </summary>
        [NameInMap("defaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>Indicates whether the format is defined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flase</para>
        /// </summary>
        [NameInMap("definesFormat")]
        [Validation(Required=false)]
        public bool? DefinesFormat { get; set; }

        /// <summary>
        /// <para>The description of the parameter.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the parameter key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Indicates whether the parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>Indiactes whether the data is sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

    }

}
