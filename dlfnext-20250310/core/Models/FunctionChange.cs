// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FunctionChange : TeaModel {
        /// <summary>
        /// <para>The change type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>setOption</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>required in UpdateFunctionComment</para>
        /// 
        /// <b>Example:</b>
        /// <para>Function configuration update</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>required in AddDefinition/UpdateDefinition</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public FunctionDefinition Definition { get; set; }

        /// <summary>
        /// <para>required in SetFunctionOption/RemoveFunctionOption</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespaceSchema</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>required in AddDefinition/UpdateDefinition/DropDefinition</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_function</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>required in SetFunctionOption</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDC_MOVE</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
