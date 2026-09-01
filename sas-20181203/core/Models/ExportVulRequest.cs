// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportVulRequest : TeaModel {
        /// <summary>
        /// <para>The name of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2019:3197-Important: sudo security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The asset type where the vulnerability is detected. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: host asset</description></item>
        /// <item><description><b>CONTAINER</b>: container asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The additional vulnerability type when querying application vulnerabilities. This parameter is required when Type is set to app. The value is fixed as <b>sca</b>.</para>
        /// <remarks>
        /// <para>If this parameter is set to <b>sca</b>, both application vulnerabilities (<b>app</b> type) and software composition analysis (<b>sca</b> type) vulnerabilities are queried. If this parameter is not set, only application vulnerabilities are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// <para>The name of the container affected by the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-7b87597b99-mcskr</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the first scan was performed.</para>
        /// <remarks>
        /// <para>The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1696186800000</para>
        /// </summary>
        [NameInMap("CreateTsEnd")]
        [Validation(Required=false)]
        public long? CreateTsEnd { get; set; }

        /// <summary>
        /// <para>The start of the time range during which the first scan was performed.</para>
        /// <remarks>
        /// <para>The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1696128144000</para>
        /// </summary>
        [NameInMap("CreateTsStart")]
        [Validation(Required=false)]
        public long? CreateTsStart { get; set; }

        /// <summary>
        /// <para>The CVE ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2022-44702</para>
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerability is fixed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: fixed</description></item>
        /// <item><description><b>n</b>: not fixed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The ID of the asset group to which the server with the vulnerability belongs.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8834224</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the image affected by the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>container-<em><b>:</b></em>*</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The priority of the vulnerability to query. Separate multiple priorities with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: high</description></item>
        /// <item><description><b>later</b>: medium</description></item>
        /// <item><description><b>nntf</b>: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The path of the process affected by the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Specifies whether runtime application self-protection (RASP) supports real-time protection against the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not supported.</description></item>
        /// <item><description><b>1</b>: Supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// <para>The ID of the resource directory account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Filters results by label. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Restart required</description></item>
        /// <item><description>Remote utilization</description></item>
        /// <item><description>EXP exists</description></item>
        /// <item><description>Exploitable</description></item>
        /// <item><description>Privilege escalation</description></item>
        /// <item><description>Code execution</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>Restart required</b></description></item>
        /// <item><description><b>Remote utilization</b></description></item>
        /// <item><description><b>EXP exists</b></description></item>
        /// <item><description><b>Available</b></description></item>
        /// <item><description><b>Elevation of Privilege</b></description></item>
        /// <item><description><b>Code Execution</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Restart required</para>
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// <para>The type of vulnerabilities to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>emg</b>: emergency vulnerability</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to query for vulnerabilities. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1587bedb-fdb4-48c4-9330-****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// <para>The instance IDs of the VPC-connected instances to query for vulnerabilities. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ins-133****,ins-5414****</para>
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

        /// <summary>
        /// <para>The list of vulnerability component information.</para>
        /// </summary>
        [NameInMap("VulEntityList")]
        [Validation(Required=false)]
        public List<ExportVulRequestVulEntityList> VulEntityList { get; set; }
        public class ExportVulRequestVulEntityList : TeaModel {
            /// <summary>
            /// <para>The name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ollama</para>
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// <para>The version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("EntityVersion")]
            [Validation(Required=false)]
            public string EntityVersion { get; set; }

        }

    }

}
