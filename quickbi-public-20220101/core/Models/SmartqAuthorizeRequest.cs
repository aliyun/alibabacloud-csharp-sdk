// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthorizeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2099-12-31</para>
        /// </summary>
        [NameInMap("ExpireDay")]
        [Validation(Required=false)]
        public string ExpireDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("LlmCubeThemes")]
        [Validation(Required=false)]
        public string LlmCubeThemes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("LlmCubes")]
        [Validation(Required=false)]
        public string LlmCubes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wasdasd<em><b><b><b>1235235sd,ASDAS</b></b></b></em>**ASDAW123</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
