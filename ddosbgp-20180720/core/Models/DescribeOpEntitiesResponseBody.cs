// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the operation log.</para>
        /// </summary>
        [NameInMap("OpEntities")]
        [Validation(Required=false)]
        public List<DescribeOpEntitiesResponseBodyOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseBodyOpEntities : TeaModel {
            /// <summary>
            /// <para>The operation object, which is the ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-n6w1r7nz****</para>
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// <para>The type of the operation object. The value is fixed as <b>1</b>, which indicates Anti-DDoS Origin instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the log was generated. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635818114000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that performs the operation.</para>
            /// <remarks>
            /// <para>If the value is <b>system</b>, the operation is performed by Anti-DDoS Origin.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>171986973287****</para>
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// <para>The type of operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: indicates an operation to add an IP address to the Anti-DDoS Origin instance for protection.</description></item>
            /// <item><description><b>4</b>: indicates an operation to remove a protected IP address from the Anti-DDoS Origin instance.</description></item>
            /// <item><description><b>5</b>: indicates an operation to downgrade the Anti-DDoS Origin instance.</description></item>
            /// <item><description><b>6</b>: indicates an operation to deactivate blackhole filtering for an IP address.</description></item>
            /// <item><description><b>7</b>: indicates an operation to reset the number of times that you can deactivate blackhole filtering.</description></item>
            /// <item><description><b>8</b>: indicates an operation to enable burstable protection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <para>The details of the operation. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>entity</b>: the operation object. Data type: object. The fields that are included in the value of the <b>entity</b> parameter vary based on the value of the <b>OpAction</b> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If the value of the <b>OpAction</b> parameter is <b>3</b>, the value of the <b>entity</b> parameter consists of the following field:</para>
            /// <list type="bullet">
            /// <item><description><b>ips</b>: the public IP addresses that are protected by the Anti-DDoS Origin instance. Data type: array</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the value of the <b>OpAction</b> parameter is <b>4</b>, the value of the <b>entity</b> parameter consists of the following field:</para>
            /// <list type="bullet">
            /// <item><description><b>ips</b>: the public IP addresses that are no longer protected by the Anti-DDoS Origin instance. Data type: array.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the value of the <b>OpAction</b> parameter is <b>5</b>, the value of the <b>entity</b> parameter consists of the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>baseBandwidth</b>: the basic protection bandwidth. Unit: Gbit/s. Data type: integer.</description></item>
            /// <item><description><b>elasticBandwidth</b>: the burstable protection bandwidth. Unit: Gbit/s. Data type: integer.</description></item>
            /// <item><description><b>opSource</b>: the source of the operation. The value is fixed as <b>1</b>, indicating that the operation is performed by Anti-DDoS Origin. Data type: integer.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the value of the <b>OpAction</b> parameter is <b>6</b>, the value of the <b>entity</b> parameter consists of the following field:</para>
            /// <list type="bullet">
            /// <item><description><b>ips</b>: the public IP addresses for which to deactivate blackhole filtering. Data type: array.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If the value of the <b>OpAction</b> parameter is <b>7</b>, the <b>entity</b> parameter is not returned.</para>
            /// </description></item>
            /// <item><description><para>If the value of the <b>OpAction</b> parameter is <b>8</b>, the value of the <b>entity</b> parameter consists of the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>baseBandwidth</b>: the basic protection bandwidth. Unit: Gbit/s. Data type: integer.</description></item>
            /// <item><description><b>elasticBandwidth</b>: the burstable protection bandwidth. Unit: Gbit/s. Data type: integer.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;entity&quot;:{&quot;baseBandwidth&quot;:20,&quot;elasticBandwidth&quot;:20}}</para>
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52C8ECB0-0B1A-4E66-A31C-B6A855120E82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of operation logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
