// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the verification.</para>
        /// </summary>
        [NameInMap("CheckTaskInfos")]
        [Validation(Required=false)]
        public List<VerifyPlaybookResponseBodyCheckTaskInfos> CheckTaskInfos { get; set; }
        public class VerifyPlaybookResponseBodyCheckTaskInfos : TeaModel {
            /// <summary>
            /// <para>The error message returned when the playbook does not pass the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node [python3_3] doesn\&quot;t have the asset information</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

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
            /// <para>The severity level of the verification information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>warn: An issue may occur during playbook running.</description></item>
            /// <item><description>error: The playbook cannot be compiled.</description></item>
            /// <item><description>remind: The publishing and running of the playbook are not affected. We recommend that you optimize the playbook format.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DFC9403-54EB-5672-B690-9AA93C9EBB54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
