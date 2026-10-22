// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class SubmitPenetrationTestRequest : TeaModel {
        /// <summary>
        /// <para>The asset list.</para>
        /// <remarks>
        /// <para>The array supports a maximum of 50 IP addresses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;AssetType&quot;:&quot;SLB&quot;,&quot;Ip&quot;:&quot;47.114.52.93&quot;}]</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public string AssetList { get; set; }

        /// <summary>
        /// <para>Specifies whether the test is performed by a third-party testing service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsThirdpartyTest")]
        [Validation(Required=false)]
        public bool? IsThirdpartyTest { get; set; }

        /// <summary>
        /// <para>The test content.</para>
        /// <remarks>
        /// <para>The content must not exceed 500 characters. Provide detailed information to facilitate the approval process.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>security test</para>
        /// </summary>
        [NameInMap("TestContent")]
        [Validation(Required=false)]
        public string TestContent { get; set; }

        /// <summary>
        /// <para>The end time of the test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-30</para>
        /// </summary>
        [NameInMap("TestEndDate")]
        [Validation(Required=false)]
        public string TestEndDate { get; set; }

        /// <summary>
        /// <para>The source IP addresses used for the test.</para>
        /// <remarks>
        /// <para>A maximum of 50 IP addresses are supported. Separate multiple IP addresses with line breaks or commas (,). 0.0.0.0 indicates that all IP addresses are allowed. CIDR blocks such as 140.168.0.0/16 are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0</para>
        /// </summary>
        [NameInMap("TestSourceIps")]
        [Validation(Required=false)]
        public string TestSourceIps { get; set; }

        /// <summary>
        /// <para>The start date of the test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-30</para>
        /// </summary>
        [NameInMap("TestStartDate")]
        [Validation(Required=false)]
        public string TestStartDate { get; set; }

        /// <summary>
        /// <para>The test steps.</para>
        /// <remarks>
        /// <para>The steps must not exceed 500 characters. Provide detailed information to facilitate the approval process.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("TestSteps")]
        [Validation(Required=false)]
        public string TestSteps { get; set; }

        /// <summary>
        /// <para>The email address of the third-party tester.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:123xxxxx@xx.com">123xxxxx@xx.com</a></para>
        /// </summary>
        [NameInMap("ThirdpartyEmail")]
        [Validation(Required=false)]
        public string ThirdpartyEmail { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the third-party tester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177xxxxxx21</para>
        /// </summary>
        [NameInMap("ThirdpartyMobile")]
        [Validation(Required=false)]
        public string ThirdpartyMobile { get; set; }

        /// <summary>
        /// <para>The third-party tester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("ThirdpartyTester")]
        [Validation(Required=false)]
        public string ThirdpartyTester { get; set; }

    }

}
