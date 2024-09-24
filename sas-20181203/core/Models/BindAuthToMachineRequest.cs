// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        /// <summary>
        /// <para>The edition of Security Center that is authorized to scan the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>6</b>: Anti-virus</description></item>
        /// <item><description><b>5</b>: Advanced</description></item>
        /// <item><description><b>3</b>: Enterprise</description></item>
        /// <item><description><b>7</b>: Ultimate</description></item>
        /// <item><description><b>10</b>: Value-added Plan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("AuthVersion")]
        [Validation(Required=false)]
        public int? AuthVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically bind servers to Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers that you want to bind to Security Center.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>Bind</b> and <b>UnBind</b> parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Bind")]
        [Validation(Required=false)]
        public List<string> Bind { get; set; }

        /// <summary>
        /// <para>Specifies whether to bind all servers to Security Center. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// <para>The search conditions that are used to filter servers. The value of this parameter is in the JSON format and is case-sensitive.</para>
        /// <remarks>
        /// <para> A search condition can be an instance ID, instance name, virtual private cloud (VPC) ID, region, or public IP address. You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;riskStatus&quot;,&quot;value&quot;:&quot;YES&quot;},{&quot;name&quot;:&quot;internetIp&quot;,&quot;value&quot;:&quot;1.2.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>Specifies whether to specify servers for protection when you purchase Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify servers, the servers are automatically added to Security Center for protection after the purchase order is complete.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsPreBind")]
        [Validation(Required=false)]
        public int? IsPreBind { get; set; }

        /// <summary>
        /// <para>The logical relationship that you want to use to evaluate multiple search conditions. Default value: <b>OR</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>****</description></item>
        /// <item><description><b>AND</b>****</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The edition of Security Center that you purchase in the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level7</b>: Anti-virus</description></item>
        /// <item><description><b>level3</b>: Advanced</description></item>
        /// <item><description><b>level2</b>: Enterprise</description></item>
        /// <item><description><b>level8</b>: Ultimate</description></item>
        /// <item><description><b>level10</b>: Value-added Plan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>level2</para>
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// <para>The ID of the order in which Security Center is purchased and servers are specified for protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233016**0482</para>
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers that you want to unbind from Security Center.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>Bind</b> and <b>UnBind</b> parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnBind")]
        [Validation(Required=false)]
        public List<string> UnBind { get; set; }

    }

}
