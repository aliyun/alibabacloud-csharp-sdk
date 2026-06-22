// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUuidsByVulNamesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the vulnerability has been handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: handled</description></item>
        /// <item><description><b>n</b>: not handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The container search field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The container search field value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-adad-qeqwe</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11286014</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The vulnerability level. Separate multiple levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: high</description></item>
        /// <item><description><b>medium</b>: medium</description></item>
        /// <item><description><b>low</b>: low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high,low</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The priority level of vulnerability fixing. Separate multiple levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: high</description></item>
        /// <item><description><b>later</b>: medium</description></item>
        /// <item><description><b>nntf</b>: low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap,later,nntf</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The asset information for the vulnerability query. You can set this parameter to the asset name, public IP address, or private IP address. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.7.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The tag for querying vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oval</para>
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// <para>The fix status of the vulnerability. Separate multiple statuses with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: unfixed</description></item>
        /// <item><description><b>2</b>: fix failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// <para>The vulnerability tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oval</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: container ID</description></item>
        /// <item><description><b>uuid</b>: asset ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The instance IDs of VPC-connected instances to query for vulnerabilities. Separate multiple instance IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6ssrvbrwe37ekw****,vpc-bp1aevy8sofi8mh1q****</para>
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

        /// <summary>
        /// <para>The collection of vulnerability names.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedVul~~">DescribeGroupedVul</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VulNames")]
        [Validation(Required=false)]
        public List<string> VulNames { get; set; }

    }

}
