// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateDiagnosticRequest : TeaModel {
        /// <summary>
        /// <para>The keyword in the diagnosis.</para>
        /// <para>You can specify the ID of the stack that you want to diagnose.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37A5679B-8488-5A5D-8D5C-90E66A577A5D</para>
        /// </summary>
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        /// <summary>
        /// <para>The type of the item that is diagnosed. Set the value to Stack, which specifies that the stack is diagnosed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stack</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <para>The language of the diagnostic report to be generated. Only Chinese and English are supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-cn</description></item>
        /// <item><description>en</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the product that is diagonosed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
