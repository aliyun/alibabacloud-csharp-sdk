// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Operation logs details.</para>
        /// </summary>
        [NameInMap("OpEntities")]
        [Validation(Required=false)]
        public List<DescribeOpEntitiesResponseBodyOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseBodyOpEntities : TeaModel {
            /// <summary>
            /// <para>The operation object, which is the ID of the Anti-DDoS Origin instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-n6w1r7nz****</para>
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// <para>The object type of the operation. The value is fixed as <b>1</b>, which indicates an Anti-DDoS Origin instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the log was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635818114000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID used to execute the operation.</para>
            /// <remarks>
            /// <para>If the value is <b>system</b>, the Anti-DDoS Origin service will automatically execute the operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>171986973287****</para>
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: add protected IP addresses to the Anti-DDoS Origin instance</description></item>
            /// <item><description><b>4</b>: unbind protected IP addresses from the Anti-DDoS Origin instance</description></item>
            /// <item><description><b>5</b>: downgrade the Anti-DDoS Origin instance</description></item>
            /// <item><description><b>6</b>: deactivate blackhole filtering</description></item>
            /// <item><description><b>7</b>: reset the quota on blackhole filtering deactivation</description></item>
            /// <item><description><b>8</b>: resume burstable protection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <para>The operation details. Use a JSON struct to transform the data into a character string representation. The JSON structure contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>entity</b>: Object | The operation object. The fields contained in <b>entity</b> vary based on the operation type (<b>OpAction</b>). Details:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>OpAction</b> is <b>3</b> (add protected IP addresses), <b>entity</b> contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>ips</b>: Array | The list of assets that are assigned public IP addresses that are attached to the Anti-DDoS Origin instance for protection.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>OpAction</b> is <b>4</b> (unbind protected IP addresses), <b>entity</b> contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>ips</b>: Array | The list of assets that are assigned public IP addresses that are unbound from the Anti-DDoS Origin instance.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>OpAction</b> is <b>5</b> (decrease the quota of the instance), <b>entity</b> contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>baseBandwidth</b>: Integer | The basic protection bandwidth. Unit: Gbit/s.</description></item>
            /// <item><description><b>elasticBandwidth</b>: Integer | The burstable protection bandwidth. Unit: Gbit/s.</description></item>
            /// <item><description><b>opSource</b>: Integer | The source of the operation. The value is fixed as <b>1</b>, which indicates that the Anti-DDoS Origin service will automatically execute the operation.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>OpAction</b> is <b>6</b> (deactivate blackhole filtering), <b>entity</b> contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>ips</b>: Array | The list of assets that are assigned public IP addresses for which the blackhole filtering status is deactivated.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>OpAction</b> is <b>7</b> (Reset quota on blackhole filtering deactivation), <b>entity</b> is empty.</para>
            /// </description></item>
            /// <item><description><para>If <b>OpAction</b> is <b>8</b> (recover burstable protection), <b>entity</b> contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>baseBandwidth</b>: Integer | The basic protection bandwidth. Unit: Gbit/s.</description></item>
            /// <item><description><b>elasticBandwidth</b>: Integer | The burstable protection bandwidth. Unit: Gbit/s.</description></item>
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
        /// <para>The total number of queried operation logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
