// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentExplorer20260317.Models
{
    public class Category : TeaModel {
        /// <summary>
        /// <para>Sub-categories</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<CategoryChildren> Children { get; set; }
        public class CategoryChildren : TeaModel {
            /// <summary>
            /// <para>Level 2 Category Code</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Level 2 Category Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>弹性计算</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Level 1 Category Code</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Level 1 Category Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>计算</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
