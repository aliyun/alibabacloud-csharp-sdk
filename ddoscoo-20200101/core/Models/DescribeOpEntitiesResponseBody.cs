// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the operation log.</para>
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
            /// <item><description><b>1</b>: the IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance</description></item>
            /// <item><description><b>2</b>: Anti-DDoS plans</description></item>
            /// <item><description><b>3</b>: ECS instances</description></item>
            /// <item><description><b>4</b>: all logs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the operation was performed. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584451769000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to call the API operation.</para>
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
            /// <item><description><b>8</b>: changing IP addresses of ECS instances.</description></item>
            /// <item><description><b>9</b>: deactivating blackhole filtering.</description></item>
            /// <item><description><b>10</b>: configuring the Diversion from Origin Server policy.</description></item>
            /// <item><description><b>11</b>: clearing all logs.</description></item>
            /// <item><description><b>12</b>: downgrading the specifications of instances. If the instance expires or the account has overdue payments, this operation is performed to downgrade the burstable protection bandwidth.</description></item>
            /// <item><description><b>13</b>: restoring the specifications of instances. If the instance is renewed or you have paid the overdue payments within your account, this operation is performed to restore the burstable protection bandwidth.</description></item>
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
            /// <item><description><b>newEntity</b>: the values of the parameters after the operation. This field must be of the STRING type.</description></item>
            /// <item><description><b>oldEntity</b>: the values of the parameters before the operation. This field must be of the STRING type.</description></item>
            /// </list>
            /// <para>Both <b>newEntity</b> and <b>oldEntity</b> are JSON strings. The returned parameters vary with <b>OpAtion</b>.</para>
            /// <para>If <b>OpAction</b> is <b>1</b>, <b>12</b>, or <b>13</b>, the following parameter is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>elasticBandwidth</b>: the burstable protection bandwidth. The value is of the INTEGER type.</para>
            /// <para>For example: <c>{&quot;newEntity&quot;:{&quot;elasticBandwidth&quot;:300},&quot;oldEntity&quot;:{&quot;elasticBandwidth&quot;:300}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If <b>OpAction</b> is <b>5</b>, the following parameters are returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>bandwidth</b>: the burstable protection bandwidth. The value is of the INTEGER type. Unit: Gbit/s.</para>
            /// </description></item>
            /// <item><description><para><b>count</b>: the number of Anti-DDoS plans. The value is of the INTEGER type.</para>
            /// </description></item>
            /// <item><description><para><b>deductCount</b>: the number of used Anti-DDoS plans. The value is of the INTEGER type.</para>
            /// </description></item>
            /// <item><description><para><b>expireTime</b>: the expiration time of the Anti-DDoS plans. The value is of the LONG type. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// </description></item>
            /// <item><description><para><b>instanceId</b>: the ID of the instance. The value is of the STRING type.</para>
            /// </description></item>
            /// <item><description><para><b>peakFlow</b>: the peak throughput on the instance. The value is of the INTEGER type. Unit: bit/s.</para>
            /// <para>For example: <c>{&quot;newEntity&quot;:{&quot;bandwidth&quot;:100,&quot;count&quot;:4,&quot;deductCount&quot;:1,&quot;expireTime&quot;:1616299196000,&quot;instanceId&quot;:&quot;ddoscoo-cn-v641kpmq****&quot;,&quot;peakFlow&quot;:751427000}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If <b>OpAction</b> is <b>8</b>, the following parameter is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>instanceId</b>: the ID of the ECS instance whose IP address is changed. The value is of the STRING type.</para>
            /// <para>For example: <c>{&quot;newEntity&quot;:{&quot;instanceId&quot;:&quot;i-wz9h6nc313zptbqn****&quot;}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If <b>OpAction</b> is <b>9</b>, the following parameter is returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>actionMethod</b>: the operation method. The value is of the STRING type. Valid value: <b>undo</b>, which indicates that you deactivated blackhole filtering.</para>
            /// <para>For example: <c>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If <b>OpAction</b> is <b>10</b>, the following parameters are returned:</para>
            /// <list type="bullet">
            /// <item><description><para><b>actionMethod</b>: the operation method. The value is of the STRING type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>do</b>: The Diversion from Origin Server policy is enabled.</description></item>
            /// <item><description><b>undo</b>: The Diversion from Origin Server policy is disabled.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>lines</b>: The Internet service provider (ISP) line from which the traffic is blocked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ct</b>: China Telecom (International)</description></item>
            /// <item><description><b>cut</b>: China Unicom (International)</description></item>
            /// </list>
            /// <para>For example: <c>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;,&quot;lines&quot;:[&quot;ct&quot;]}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>If <b>OpAction</b> is <b>11</b>, no parameter is returned, and the description is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;}}</para>
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
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
