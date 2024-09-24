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
        /// <para>The additional type of the vulnerabilities. You need to specify this parameter when you query application vulnerabilities. If you set the Type parameter to app, you must specify this parameter. Set the value to <b>sca</b>.</para>
        /// <remarks>
        /// <para>If this parameter is set to <b>sca</b>, <b>application vulnerabilities</b> and the <b>vulnerabilities that are detected based on software component analysis</b> are queried. If you do not specify this parameter, only application vulnerabilities are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// <para>The name of the container that is affected by the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-7b87597b99-mcskr</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The end time of the first scan.</para>
        /// <remarks>
        /// <para> This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1696186800000</para>
        /// </summary>
        [NameInMap("CreateTsEnd")]
        [Validation(Required=false)]
        public long? CreateTsEnd { get; set; }

        /// <summary>
        /// <para>The start time of the first scan.</para>
        /// <remarks>
        /// <para> This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1696128144000</para>
        /// </summary>
        [NameInMap("CreateTsStart")]
        [Validation(Required=false)]
        public long? CreateTsStart { get; set; }

        /// <summary>
        /// <para>The Common Vulnerabilities and Exposures (CVE) ID of the vulnerability.</para>
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
        /// <item><description><b>y</b>: The vulnerability is fixed.</description></item>
        /// <item><description><b>n</b>: The vulnerability is not fixed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The server group ID of the server on which the vulnerabilities are detected.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of server groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8834224</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the image that is affected by the vulnerability.</para>
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
        /// <para>The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:</para>
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
        /// <para>The path of the process that is affected by the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The tag that is used to search for the vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Restart required</description></item>
        /// <item><description>Remote exploitation</description></item>
        /// <item><description>Exploit exists</description></item>
        /// <item><description>Exploitable</description></item>
        /// <item><description>Privilege escalation</description></item>
        /// <item><description>Code execution</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Restart required</para>
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability that you want to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability</description></item>
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
        /// <para>The UUID of the server on which the vulnerabilities are detected. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1587bedb-fdb4-48c4-9330-****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which the vulnerabilities are detected. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to query the IDs of VPCs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ins-133****,ins-5414****</para>
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

    }

}
