// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateVariableGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>变量组</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>变量组</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;isEncrypted&quot;:true,&quot;name&quot;:&quot;name1&quot;,&quot;value&quot;:&quot;vaue1&quot;}]</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
