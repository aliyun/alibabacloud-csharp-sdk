// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPythonFileRequest : TeaModel {
        /// <summary>
        /// <para>The Python code snippet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import logging
        /// def execute (params):
        ///   success=True
        ///   message=\&quot;OK\&quot;
        ///   data=[]
        ///   return (success,message,data)</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
