// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation records.</para>
        /// </summary>
        [NameInMap("OpEntities")]
        [Validation(Required=false)]
        public List<DescribeOpEntitiesResponseBodyOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseBodyOpEntities : TeaModel {
            /// <summary>
            /// <para>The operation object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.132</para>
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// <para>The type of the operation object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: the IP address of the Anti-DDoS Proxy instance.</description></item>
            /// <item><description><b>2</b>: Anti-DDoS plans.</description></item>
            /// <item><description><b>3</b>: ECS instances.</description></item>
            /// <item><description><b>4</b>: all logs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the operation was performed. The value is a UNIX timestamp. Units: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584451769000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to perform the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128965410602****</para>
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// <para>The type of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: configuring burstable protection bandwidth.</description></item>
            /// <item><description><b>5</b>: using Anti-DDoS plans.</description></item>
            /// <item><description><b>8</b>: changing the IP addresses of ECS instances.</description></item>
            /// <item><description><b>9</b>: deactivating blackhole filtering.</description></item>
            /// <item><description><b>10</b>: configuring the near-origin traffic diversion feature.</description></item>
            /// <item><description><b>11</b>: clearing all logs.</description></item>
            /// <item><description><b>12</b>: downgrading the specifications of the Anti-DDoS Proxy instance. If the instance expires or the account has overdue payments, this operation is performed to downgrade the burstable protection bandwidth.</description></item>
            /// <item><description><b>13</b>: restoring the specifications of the Anti-DDoS Proxy instance. If the instance is renewed or you have paid the overdue payments within your account, this operation is performed to restore the burstable protection bandwidth.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <para>The details of the operation. This parameter is a JSON string. The string contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>newEntity</b>: the values of the parameters after the operation. This field is of the string type.</description></item>
            /// <item><description><b>oldEntity</b>: the values of the parameters before the operation. This field is of the string type.</description></item>
            /// </list>
            /// <para>Both <b>newEntity</b> and <b>oldEntity</b> are JSON strings. The returned parameters vary based on <b>OpAction</b>.</para>
            /// <para>If the value of <b>OpAction</b> is <b>1</b>, <b>12</b>, or <b>13</b>, the following parameter is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>elasticBandwidth</b>: the burstable protection bandwidth. This parameter is of the integer type. Unit: Gbit/s.</para>
            /// <para>Example: <c>{&quot;newEntity&quot;:{&quot;elasticBandwidth&quot;:300},&quot;oldEntity&quot;:{&quot;elasticBandwidth&quot;:300}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If the value of <b>OpAction</b> is <b>5</b>, the following parameters are returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>bandwidth</b>: the burstable protection bandwidth. The parameter is of the integer type. Unit: Gbit/s.</para>
            /// </description></item>
            /// <item><description><para><b>count</b>: the number of Anti-DDoS plans. This parameter is of the integer type.</para>
            /// </description></item>
            /// <item><description><para><b>deductCount</b>: the number of used Anti-DDoS plans. This parameter is of the integer type.</para>
            /// </description></item>
            /// <item><description><para><b>expireTime</b>: the expiration time of the Anti-DDoS plans. This parameter is of the long type. The value is a UNIX timestamp. Units: milliseconds.</para>
            /// </description></item>
            /// <item><description><para><b>instanceId</b>: the ID of the Anti-DDoS Proxy instance. This parameter is of the string type.</para>
            /// </description></item>
            /// <item><description><para><b>peakFlow</b>: the peak throughput on the Anti-DDoS Proxy instance. This parameter is of the integer type. Unit: bit/s.</para>
            /// <para>Example: <c>{&quot;newEntity&quot;:{&quot;bandwidth&quot;:100,&quot;count&quot;:4,&quot;deductCount&quot;:1,&quot;expireTime&quot;:1616299196000,&quot;instanceId&quot;:&quot;ddoscoo-cn-v641kpmq****&quot;,&quot;peakFlow&quot;:751427000}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If the value of <b>OpAction</b> is <b>8</b>, the following parameter is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>instanceId</b>: the IDs of the ECS instances whose IP addresses are changed. This parameter is of the string type.</para>
            /// <para>Example: <c>{&quot;newEntity&quot;:{&quot;instanceId&quot;:&quot;i-wz9h6nc313zptbqn****&quot;}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If the value of <b>OpAction</b> is <b>9</b>, the following parameter is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>actionMethod</b>: the operation method. This parameter is of the string type. Valid value: <b>undo</b>, which indicates that you deactivated blackhole filtering.</para>
            /// <para>Example: <c>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If the value of <b>OpAction</b> is <b>10</b>, the following parameters are returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>actionMethod</b>: the operation method. This parameter is of the string type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>do</b>: The near-origin traffic diversion feature is enabled.</description></item>
            /// <item><description><b>undo</b>: The near-origin traffic diversion feature is disabled.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>lines</b>: the Internet service provider (ISP) line from which the traffic is blocked. This parameter is of the array type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ct</b>: China Telecom (International).</description></item>
            /// <item><description><b>cut</b>: China Unicom (International).</description></item>
            /// </list>
            /// <para>Example: <c>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;,&quot;lines&quot;:[&quot;ct&quot;]}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If the value of <b>OpAction</b> is <b>11</b>, no parameter is returned, and the description is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;}}</para>
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FB24D70C-71F5-4000-8CD8-22CDA0C53CD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned operation records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
