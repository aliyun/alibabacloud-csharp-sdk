// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification results.</para>
        /// </summary>
        [NameInMap("CheckTaskInfos")]
        [Validation(Required=false)]
        public List<VerifyPlaybookResponseBodyCheckTaskInfos> CheckTaskInfos { get; set; }
        public class VerifyPlaybookResponseBodyCheckTaskInfos : TeaModel {
            /// <summary>
            /// <para>The specific error message that is returned if the verification fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node [python3_3] doesn\&quot;t have the asset information</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The name of the playbook node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>python3_3</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The severity level of the verification message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>warn</b>: A warning message. An issue may occur when the playbook runs.</para>
            /// </description></item>
            /// <item><description><para><b>error</b>: An error message. The playbook fails to be compiled.</para>
            /// </description></item>
            /// <item><description><para><b>remind</b>: A suggestion. This does not affect publishing or running the playbook. Optimize the playbook format.</para>
            /// </description></item>
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
        /// <para>The prerequisite check information for the playbook.</para>
        /// </summary>
        [NameInMap("Prerequisites")]
        [Validation(Required=false)]
        public List<VerifyPlaybookResponseBodyPrerequisites> Prerequisites { get; set; }
        public class VerifyPlaybookResponseBodyPrerequisites : TeaModel {
            /// <summary>
            /// <para>The check type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>role</b>: The name of the custom RAM role.</para>
            /// </description></item>
            /// <item><description><para><b>policies</b>: The list of RAM system policies.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>role</para>
            /// </summary>
            [NameInMap("PrerequisiteType")]
            [Validation(Required=false)]
            public string PrerequisiteType { get; set; }

            /// <summary>
            /// <para>The check content. The value is determined as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>If PrerequisiteType is <b>role</b>, the value is the static field AliyunSiemSoarExecutionDefaultRole.</para>
            /// </description></item>
            /// <item><description><para>If PrerequisiteType is <b>policies</b>, the value is a collection of policy names.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunSiemSoarExecutionDefaultRole</para>
            /// </summary>
            [NameInMap("PrerequisiteValue")]
            [Validation(Required=false)]
            public string PrerequisiteValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates this unique identifier for the request. Use this ID to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DFC9403-54EB-5672-B690-9AA93C9EBB54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
