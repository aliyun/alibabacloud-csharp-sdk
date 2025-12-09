// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the pay-as-you-go instance. This parameter is required.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/421770.html">DescribeVersionConfig</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>The switch status of the pay-as-you-go module. The value is a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Key:</para>
        /// <list type="bullet">
        /// <item><description><b>VUL</b>: vulnerability fixing module</description></item>
        /// <item><description><b>CSPM</b>: cloud service configuration check module</description></item>
        /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
        /// <item><description><b>SERVERLESS</b>: serverless asset module</description></item>
        /// <item><description><b>CTDR</b>: Threat Analysis and Response Module</description></item>
        /// <item><description><b>POST_HOST</b>: Host and Container Security Module</description></item>
        /// <item><description><b>SDK</b>: Malicious File Detection SDK Module</description></item>
        /// <item><description><b>RASP</b>: Application Protection Module</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Value: A value of 0 specifies disabled. A value of 1 specifies enabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify a value for a module, the original value of the module is retained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1,&quot;CSPM&quot;:0}</para>
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

    }

}
