// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportVulRequest : TeaModel {
        /// <summary>
        /// <para>The vulnerability name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2019:3197-Important: sudo security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>An additional vulnerability type to export. This parameter is required and must be set to <b>sca</b> if the <c>Type</c> parameter is set to <c>app</c>.</para>
        /// <remarks>
        /// <para>If you set this parameter to <b>sca</b>, the query returns both application vulnerabilities (<b>app</b>) and software composition analysis (<b>sca</b>) vulnerabilities. If you do not set this parameter, only application vulnerabilities are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// <para>The affected container name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-7b87597b99-mcskr</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The end of the creation time range for the vulnerabilities to export.</para>
        /// <remarks>
        /// <para>A Unix timestamp in milliseconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1696186800000</para>
        /// </summary>
        [NameInMap("CreateTsEnd")]
        [Validation(Required=false)]
        public long? CreateTsEnd { get; set; }

        /// <summary>
        /// <para>The start of the creation time range for the vulnerabilities to export.</para>
        /// <remarks>
        /// <para>A Unix timestamp in milliseconds.</para>
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
        /// <para>Indicates whether the vulnerability is remediated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>y</b>: Remediated</para>
        /// </description></item>
        /// <item><description><para><b>n</b>: Not remediated</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The ID of the asset group that contains the affected servers.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8834224</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The affected image name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>container-<em><b>:</b></em>*</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The remediation priority of the vulnerabilities to export. Separate multiple priorities with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asap</b>: High</para>
        /// </description></item>
        /// <item><description><para><b>later</b>: Medium</para>
        /// </description></item>
        /// <item><description><para><b>nntf</b>: Low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The affected process path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerability is protected by runtime application self-protection (RASP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Not supported</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Supported</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>A tag for filtering vulnerabilities. Separate multiple tags with commas. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>Restart required</para>
        /// </description></item>
        /// <item><description><para>remote exploitation</para>
        /// </description></item>
        /// <item><description><para>exploit exists</para>
        /// </description></item>
        /// <item><description><para>exploitable</para>
        /// </description></item>
        /// <item><description><para>Elevation of Privilege</para>
        /// </description></item>
        /// <item><description><para>Code Execution</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para><b>Restart required</b></para>
        /// </description></item>
        /// <item><description><para><b>remote exploitation</b></para>
        /// </description></item>
        /// <item><description><para><b>exploit exists</b></para>
        /// </description></item>
        /// <item><description><para><b>exploitable</b></para>
        /// </description></item>
        /// <item><description><para><b>Elevation of Privilege</b></para>
        /// </description></item>
        /// <item><description><para><b>Code Execution</b></para>
        /// </description></item>
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
        /// <item><description><para><b>cve</b>: Linux software vulnerability</para>
        /// </description></item>
        /// <item><description><para><b>sys</b>: Windows system vulnerability</para>
        /// </description></item>
        /// <item><description><para><b>cms</b>: Web-CMS vulnerability</para>
        /// </description></item>
        /// <item><description><para><b>app</b>: application vulnerability</para>
        /// </description></item>
        /// <item><description><para><b>emg</b>: emergency vulnerability</para>
        /// </description></item>
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
        /// <para>The UUIDs of the servers for which to export vulnerabilities. Separate multiple UUIDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1587bedb-fdb4-48c4-9330-****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// <para>The IDs of the VPC instances for which to export vulnerabilities. Separate multiple IDs with commas.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ins-133****,ins-5414****</para>
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

        /// <summary>
        /// <para>A list of vulnerability component information.</para>
        /// </summary>
        [NameInMap("VulEntityList")]
        [Validation(Required=false)]
        public List<ExportVulRequestVulEntityList> VulEntityList { get; set; }
        public class ExportVulRequestVulEntityList : TeaModel {
            /// <summary>
            /// <para>The component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ollama</para>
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// <para>The component version.</para>
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
