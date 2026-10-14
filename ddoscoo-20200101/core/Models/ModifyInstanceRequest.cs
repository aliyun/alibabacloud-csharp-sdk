// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The address type. Valid values:</para>
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
        /// <para>The burstable protection bandwidth (the Chinese mainland). Unit: Gbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The basic protection bandwidth (the Chinese mainland). Unit: Gbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BaseBandwidth")]
        [Validation(Required=false)]
        public string BaseBandwidth { get; set; }

        /// <summary>
        /// <para>The number of protected domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public string DomainCount { get; set; }

        /// <summary>
        /// <para>The mitigation plan (the Chinese mainland). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>coop</b>: Professional Edition of Anti-DDoS Pro or Anti-DDoS Premium (Chinese mainland).</description></item>
        /// <item><description><b>advance</b>: Professional Edition of Anti-DDoS Pro or Anti-DDoS Premium (Chinese mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>coop</para>
        /// </summary>
        [NameInMap("EditionSale")]
        [Validation(Required=false)]
        public string EditionSale { get; set; }

        /// <summary>
        /// <para>The function version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: standard features.</description></item>
        /// <item><description><b>1</b>: enhanced features.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FunctionVersion")]
        [Validation(Required=false)]
        public string FunctionVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <remarks>
        /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the IDs of all Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
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
        /// <para>The type of specification change. Valid values:</para>
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
        /// <para>The clean bandwidth (outside the Chinese mainland). Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("NormalBandwidth")]
        [Validation(Required=false)]
        public string NormalBandwidth { get; set; }

        /// <summary>
        /// <para>The clean queries per second (QPS). Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NormalQps")]
        [Validation(Required=false)]
        public string NormalQps { get; set; }

        /// <summary>
        /// <para>The number of protected ports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PortCount")]
        [Validation(Required=false)]
        public string PortCount { get; set; }

        /// <summary>
        /// <para>The mitigation plan (outside the Chinese mainland). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Insurance mitigation plan for Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland).</description></item>
        /// <item><description><b>1</b>: Unlimited mitigation plan for Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland).</description></item>
        /// <item><description><b>2</b>: acceleration line for Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland).</description></item>
        /// <item><description><b>3</b>: secure acceleration line for Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProductPlan")]
        [Validation(Required=false)]
        public string ProductPlan { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ddoscoo</b>: indicates that the China site account is used for specification changes of an Anti-DDoS Pro or Anti-DDoS Premium (Chinese mainland) instance.</description></item>
        /// <item><description><b>ddoscoo_intl</b>: indicates that the international site account is used for specification changes of an Anti-DDoS Pro or Anti-DDoS Premium (Chinese mainland) instance.</description></item>
        /// <item><description><b>ddosDip</b>: indicates that the China site account or international site account is used for specification changes of an Anti-DDoS Pro or Anti-DDoS Premium (outside the Chinese mainland) instance.</description></item>
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
        /// <para>The clean bandwidth (the Chinese mainland). Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ServiceBandwidth")]
        [Validation(Required=false)]
        public string ServiceBandwidth { get; set; }

        /// <summary>
        /// <para>The line resource of the instance (the Chinese mainland). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>coop-line-001</b>: eight-line BGP line for Anti-DDoS Pro or Anti-DDoS Premium (Chinese mainland).</description></item>
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
