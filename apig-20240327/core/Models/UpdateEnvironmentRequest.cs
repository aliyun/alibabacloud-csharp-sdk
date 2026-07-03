// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试环境</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The description of the environment. You can specify information such as the purpose and owner of the environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是xx的xx项目测试环境</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
