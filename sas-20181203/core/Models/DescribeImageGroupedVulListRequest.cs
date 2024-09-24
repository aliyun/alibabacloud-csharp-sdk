// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageGroupedVulListRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High severity vulnerability that affects org.eclipse.jetty:jetty-server</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the ID of the container cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c60b77fe62093480db6164a3c2fa5****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The Common Vulnerabilities and Exposures (CVE) ID of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2017-15420</para>
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1311</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The SHA-256 value of the image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w213412341dfsfasdfafadfasfasf</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>The layer of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1f5b9420803ad0657cf21566e3e20acc08581e7f22991249ef3aa80b8b1c587</para>
        /// </summary>
        [NameInMap("ImageLayer")]
        [Validation(Required=false)]
        public string ImageLayer { get; set; }

        /// <summary>
        /// <para>The tag of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oval</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the vulnerabilities in the latest images. If you do not specify this parameter, the vulnerabilities in all images are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: does not query the vulnerabilities in the latest images.</description></item>
        /// <item><description><b>1</b>: queries the vulnerabilities in the latest images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public int? IsLatest { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>debian:10:CVE-2019-9893</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority to fix the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: high. You must fix the vulnerability at the earliest opportunity.</description></item>
        /// <item><description><b>later</b>: medium. You can fix the vulnerability based on your business requirements.</description></item>
        /// <item><description><b>nntf</b>: low. You can ignore the vulnerability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the patch that is used to fix the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1341512412</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public long? PatchId { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qew****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The instance ID of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-qewqrqcsadf****</para>
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace to which the image repository belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// <para>The region ID of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// <para>An array consisting of the types of the assets that you want to scan.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: image system vulnerability</description></item>
        /// <item><description><b>sca</b>: image application vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUID of the asset. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid-13134124****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
