// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleDataComponentsValuePropertiesValue : TeaModel {
        /// <summary>
        /// <para>Property code (internal system identifier)</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Property display name (user-visible name)</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Property value code (internal system value)</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>Module property value list</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<ModuleDataComponentsValuePropertiesValueValues> Values { get; set; }
        public class ModuleDataComponentsValuePropertiesValueValues : TeaModel {
            /// <summary>
            /// <para>Property code (internal system identifier)</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Property value code (internal system value)</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>Property display name (user-visible name)</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
