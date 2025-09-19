// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the search conditions of assets.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The structured attribute values of the assets that match the keyword. The value of this parameter is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>vendor</b>: providers.</description></item>
            /// <item><description><b>regionIds</b>: IDs of supported regions</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;vendor&quot;:0,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;ap-southeast-1&quot;,&quot;ap-northeast-2&quot;,&quot;ap-southeast-3&quot;,&quot;ap-southeast-5&quot;,&quot;ap-southeast-7&quot;,&quot;me-central-1&quot;]}},{&quot;vendor&quot;:1,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;outside-of-aliyun&quot;]}}]</para>
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// <para>The name of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internetIp</b>: the public IP address.</description></item>
            /// <item><description><b>intranetIp</b>: the private IP address.</description></item>
            /// <item><description><b>instanceName</b>: the name of the instance.</description></item>
            /// <item><description><b>instanceId</b>: the instance ID.</description></item>
            /// <item><description><b>vpcInstanceId</b>: The ID of the virtual private cloud (VPC) to which the instance belongs.</description></item>
            /// <item><description><b>osName</b>: the operating system.</description></item>
            /// <item><description><b>osType</b>: the operating system type.</description></item>
            /// <item><description><b>hcStatus</b>: indicates whether baseline risks exist.</description></item>
            /// <item><description><b>vulStatus</b>: indicates whether vulnerabilities exist.</description></item>
            /// <item><description><b>alarmStatus</b>: indicates whether security alerts exist.</description></item>
            /// <item><description><b>riskStatus</b>: indicates whether risks exist.</description></item>
            /// <item><description><b>clientStatus</b>: indicates the status of the client.</description></item>
            /// <item><description><b>runningStatus</b>: the running status of the asset.</description></item>
            /// <item><description><b>tagName</b>: the name of the tag.</description></item>
            /// <item><description><b>groupName</b>: the name of the server group.</description></item>
            /// <item><description><b>regionId</b>: the region ID.</description></item>
            /// <item><description><b>importance</b>: the importance of the asset.</description></item>
            /// <item><description><b>exposedStatus</b>: indicates whether the server is exposed.</description></item>
            /// <item><description><b>authVersion</b>: the authorization version.</description></item>
            /// <item><description><b>flag</b>: the cloud service provider.</description></item>
            /// <item><description><b>ipList</b>: the IP address list.</description></item>
            /// <item><description><b>uuidList</b> :the UUID.</description></item>
            /// <item><description><b>tagKeyValue</b>: the ECS tag.</description></item>
            /// <item><description><b>vendorAuthAlias</b>: the account name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internetIp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: The search condition needs to be specified.</description></item>
            /// <item><description><b>select</b>: The search condition is an option that can be selected from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The attribute values of the assets that match the keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.96.XX.XX</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E6DDACF-99AF-5939-AFFD-FCCD3B01E724</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
