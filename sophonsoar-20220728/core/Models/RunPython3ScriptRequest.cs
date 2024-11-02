// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunPython3ScriptRequest : TeaModel {
        /// <summary>
        /// <para>The name of the node in the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3_3</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The input parameters of the Python3 script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;input1&quot;: &quot;xx.xx.xx.xx&quot;,
        ///     &quot;input2&quot;: &quot;7d&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to query the UUIDs of playbooks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-xxxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The Python3 script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import logging
        /// def execute (params):
        ///   #ip = params[\&quot;ip\&quot;]
        ///   #logging.info(&quot;enter execute,ip is &quot;+ip)
        ///   success=True
        ///   message=\&quot;OK\&quot;
        ///   data=[]
        ///   return (success,message,data)</para>
        /// </summary>
        [NameInMap("PythonScript")]
        [Validation(Required=false)]
        public string PythonScript { get; set; }

    }

}
