// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The check results.</para>
        /// </summary>
        [NameInMap("CheckResultList")]
        [Validation(Required=false)]
        public List<DescribeCheckResultResponseBodyCheckResultList> CheckResultList { get; set; }
        public class DescribeCheckResultResponseBodyCheckResultList : TeaModel {
            /// <summary>
            /// <para>The compliance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: compliant</description></item>
            /// <item><description><b>0</b>: non-compliant</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComplianceStatus")]
            [Validation(Required=false)]
            public int? ComplianceStatus { get; set; }

            /// <summary>
            /// <para>The name of the corresponding section. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>information_classification</b>: information classification</description></item>
            /// <item><description><b>information_mark</b>: information labeling</description></item>
            /// <item><description><b>network_security_policy</b>: access to networks and network services</description></item>
            /// <item><description><b>login_control</b>: secure logon procedures</description></item>
            /// <item><description><b>week_password</b>: password management system</description></item>
            /// <item><description><b>key_manage</b>: key management</description></item>
            /// <item><description><b>malicious_software</b>: protection against malware</description></item>
            /// <item><description><b>information_backup</b>: information backup</description></item>
            /// <item><description><b>audit_policy</b>: information system audit control mechanisms</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>information_mark</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>571B2642-BF51-5BDD-906B-D2340DB9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
