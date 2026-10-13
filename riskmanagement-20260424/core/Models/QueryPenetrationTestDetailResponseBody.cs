// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryPenetrationTestDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: success</description></item>
        /// <item><description><b>Other values (400, 500)</b>: failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response content.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPenetrationTestDetailResponseBodyData Data { get; set; }
        public class QueryPenetrationTestDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788873796000</para>
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public long? ApplyTime { get; set; }

            /// <summary>
            /// <para>The asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EIP</b>: public IP address of a VPC</description></item>
            /// <item><description><b>SLB</b>: load balancing</description></item>
            /// <item><description><b>ECS</b>: public IP address of an ECS instance in the classic network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EIP</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The unique ID of the application record.</para>
            /// <remarks>
            /// <para>This field is of the Long type. Precision loss may occur when you serialize or deserialize the value. Make sure that the value does not exceed 9007199254740991.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2387</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.113.186.91</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Indicates whether the test is performed by a third-party service provider.</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsThirdpartyTest")]
            [Validation(Required=false)]
            public bool? IsThirdpartyTest { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>early_end</b>: The user applies for early termination.</description></item>
            /// <item><description><b>expired</b>: The authorization has expired.</description></item>
            /// <item><description><b>auditing</b>: The application is being reviewed.</description></item>
            /// <item><description><b>approved</b>: The application is approved.</description></item>
            /// <item><description><b>rejected</b>: The application is rejected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>early_end</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The test content.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The content must be within 500 characters. Carefully fill in the content to increase the chance of passing the review.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>security test</para>
            /// </summary>
            [NameInMap("TestContent")]
            [Validation(Required=false)]
            public string TestContent { get; set; }

            /// <summary>
            /// <para>The test end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788873796000</para>
            /// </summary>
            [NameInMap("TestEndDate")]
            [Validation(Required=false)]
            public long? TestEndDate { get; set; }

            /// <summary>
            /// <para>The source IP addresses used for the test.</para>
            /// <remarks>
            /// <para>You can specify up to 50 IP addresses. Separate multiple IP addresses with line breaks or commas (,). Specify 0.0.0.0 to allow all IP addresses. CIDR blocks are not supported, such as 140.168.0.0/16.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("TestSourceIps")]
            [Validation(Required=false)]
            public string TestSourceIps { get; set; }

            /// <summary>
            /// <para>The test start date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788873796000</para>
            /// </summary>
            [NameInMap("TestStartDate")]
            [Validation(Required=false)]
            public long? TestStartDate { get; set; }

            /// <summary>
            /// <para>The test steps.</para>
            /// <remarks>
            /// <para>The content must be within 500 characters. Carefully fill in the content to increase the chance of passing the review.</para>
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
            /// <para><a href="mailto:12312@xxx.com">12312@xxx.com</a></para>
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

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>855FCC89-0B13-5FC0-AAD2-120878081C1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.                               </description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
