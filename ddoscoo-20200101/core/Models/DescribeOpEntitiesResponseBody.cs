// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation log records.</para>
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
            /// <item><description><b>1</b>: IP Address of Anti-DDoS Proxy instance</description></item>
            /// <item><description><b>2</b>: Anti-DDoS Pro and Anti-DDoS Premium mitigation plan</description></item>
            /// <item><description><b>3</b>: ECS instance</description></item>
            /// <item><description><b>4</b>: full logs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the operation was performed. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584451769000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that performed the operation.</para>
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
            /// <item><description><b>1</b>: Settings for the burstable protection bandwidth.</description></item>
            /// <item><description><b>5</b>: Offset with an anti-DDoS mitigation plan.</description></item>
            /// <item><description><b>8</b>: Change an ECS IP address.</description></item>
            /// <item><description><b>9</b>: Unblock (deactivation of blackhole filtering).</description></item>
            /// <item><description><b>10</b>: Settings for near-origin traffic diversion.</description></item>
            /// <item><description><b>11</b>: Clear full logs.</description></item>
            /// <item><description><b>12</b>: Downgrade instance specifications. This indicates that the burstable protection bandwidth is reduced when the instance expires or the account has an overdue payment.</description></item>
            /// <item><description><b>13</b>: Recover instance specifications. This indicates that the burstable protection bandwidth is recovered when the instance renewal is completed or the overdue payment is settled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <para>The description of the operation, expressed as a JSON format character string with the following structure:</para>
            /// <list type="bullet">
            /// <item><description><b>newEntity</b>: String. The parameters after the operation.</description></item>
            /// <item><description><b>oldEntity</b>: String. The parameters before the operation.</description></item>
            /// </list>
            /// <para>Both <b>newEntity</b> and <b>oldEntity</b> are expressed as JSON format character strings. The operation parameters vary based on the operation type (<b>OpAction</b>).</para>
            /// <para>When <b>OpAction</b> is <b>1</b>, <b>12</b>, or <b>13</b>, the operation parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>elasticBandwidth</b>: Integer. The burstable protection bandwidth. Unit: Gbit/s.</para>
            /// <para>  Example: <c>{&quot;newEntity&quot;:{&quot;elasticBandwidth&quot;:300},&quot;oldEntity&quot;:{&quot;elasticBandwidth&quot;:300}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>When <b>OpAction</b> is <b>5</b>, the operation parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>bandwidth</b>: Integer. The burstable protection bandwidth. Unit: Gbit/s.</para>
            /// </description></item>
            /// <item><description><para><b>count</b>: Integer. The number of anti-DDoS mitigation plans.</para>
            /// </description></item>
            /// <item><description><para><b>deductCount</b>: Integer. The number of offset anti-DDoS mitigation plans.</para>
            /// </description></item>
            /// <item><description><para><b>expireTime</b>: Long. The expiration time of the anti-DDoS mitigation plan. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// </description></item>
            /// <item><description><para><b>instanceId</b>: String. The instance ID of the Anti-DDoS Pro and Anti-DDoS Premium instance.</para>
            /// </description></item>
            /// <item><description><para><b>peakFlow</b>: Integer. The peak traffic. Unit: bit/s.</para>
            /// <para>  Example: <c>{&quot;newEntity&quot;:{&quot;bandwidth&quot;:100,&quot;count&quot;:4,&quot;deductCount&quot;:1,&quot;expireTime&quot;:1616299196000,&quot;instanceId&quot;:&quot;ddoscoo-cn-v641kpmq****&quot;,&quot;peakFlow&quot;:751427000}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>When <b>OpAction</b> is <b>8</b>, the operation parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>instanceId</b>: String. The instance ID of the ECS instance whose IP address is changed.</para>
            /// <para>  Example: <c>{&quot;newEntity&quot;:{&quot;instanceId&quot;:&quot;i-wz9h6nc313zptbqn****&quot;}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>	</para>
            /// <para>When <b>OpAction</b> is <b>9</b>, the operation parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>actionMethod</b>: String. The operation method. Value: <b>undo</b>, which indicates Unblock (deactivation of blackhole filtering).</para>
            /// <para>  Example: <c>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>	</para>
            /// <para>When <b>OpAction</b> is <b>10</b>, the operation parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>actionMethod</b>: String. The operation method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>do</b>: Enable near-origin traffic diversion.</description></item>
            /// <item><description><b>undo</b>: Disable near-origin traffic diversion.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>lines</b>: Array. The line types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ct</b>: China Telecom outside China line</description></item>
            /// <item><description><b>cut</b>: China Unicom outside China line</description></item>
            /// </list>
            /// <para>  Example: <c>{&quot;newEntity&quot;:{&quot;actionMethod&quot;:&quot;undo&quot;,&quot;lines&quot;:[&quot;ct&quot;]}}</c></para>
            /// </description></item>
            /// </list>
            /// <para>When <b>OpAction</b> is <b>11</b>, there are no operation parameters and the operation description is empty.</para>
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
        /// <para>The total number of operation records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
