// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Address type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ipv4</b>: IPv4.</description></item>
        /// <item><description><b>Ipv6</b>: IPv6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ipv4</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>Elastic protection bandwidth (Mainland China). Unit: Gbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>Guaranteed protection bandwidth (Mainland China). Unit: Gbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BaseBandwidth")]
        [Validation(Required=false)]
        public string BaseBandwidth { get; set; }

        /// <summary>
        /// <para>Number of protected domains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public string DomainCount { get; set; }

        /// <summary>
        /// <para>Protection package (Mainland China). Values:</para>
        /// <list type="bullet">
        /// <item><description><b>coop</b>: Indicates the DDoS High Defense (Mainland China) Professional Edition.</description></item>
        /// <item><description><b>advance</b>: Indicates the DDoS High Defense (Mainland China) Professional Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>coop</para>
        /// </summary>
        [NameInMap("EditionSale")]
        [Validation(Required=false)]
        public string EditionSale { get; set; }

        /// <summary>
        /// <para>Function version, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Standard function.</description></item>
        /// <item><description><b>1</b>: Enhanced function.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FunctionVersion")]
        [Validation(Required=false)]
        public string FunctionVersion { get; set; }

        /// <summary>
        /// <para>The ID of the DDoS High Defense instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the ID information of all DDoS High Defense instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-6ja1y6p5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Adjustment type, with values</para>
        /// <list type="bullet">
        /// <item><description>UPGRADE: Upgrade.</description></item>
        /// <item><description>DOWNGRADE: Downgrade.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>Business bandwidth (outside Mainland China). Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("NormalBandwidth")]
        [Validation(Required=false)]
        public string NormalBandwidth { get; set; }

        /// <summary>
        /// <para>Business QPS. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NormalQps")]
        [Validation(Required=false)]
        public string NormalQps { get; set; }

        /// <summary>
        /// <para>Number of protected ports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PortCount")]
        [Validation(Required=false)]
        public string PortCount { get; set; }

        /// <summary>
        /// <para>Protection package (outside Mainland China). Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Indicates the DDoS High Defense (outside Mainland China) Insurance Edition.</description></item>
        /// <item><description><b>1</b>: Indicates the DDoS High Defense (outside Mainland China) Worry-Free Edition.</description></item>
        /// <item><description><b>2</b>: Indicates the DDoS High Defense (outside Mainland China) Acceleration Line.</description></item>
        /// <item><description><b>3</b>: Indicates the DDoS High Defense (outside Mainland China) Secure Acceleration Line.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProductPlan")]
        [Validation(Required=false)]
        public string ProductPlan { get; set; }

        /// <summary>
        /// <para>Product type.
        /// Values:</para>
        /// <list type="bullet">
        /// <item><description><b>ddoscoo</b>: Indicates that the DDoS High Defense (Mainland China) instance is being adjusted for a China site account.</description></item>
        /// <item><description><b>ddoscoo_intl</b>: Indicates that the DDoS High Defense (Mainland China) instance is being adjusted for an international site account.</description></item>
        /// <item><description><b>ddosDip</b>: Indicates that the DDoS High Defense (outside Mainland China) instance is being adjusted for either a China or international site account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Business bandwidth (Mainland China). Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ServiceBandwidth")]
        [Validation(Required=false)]
        public string ServiceBandwidth { get; set; }

        /// <summary>
        /// <para>Line resources of the instance (Mainland China). Values:</para>
        /// <list type="bullet">
        /// <item><description><b>coop-line-001</b>: Indicates the DDoS High Defense (Mainland China) 8-line BGP line.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>coop-line-001</para>
        /// </summary>
        [NameInMap("ServicePartner")]
        [Validation(Required=false)]
        public string ServicePartner { get; set; }

    }

}
