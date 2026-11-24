// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagScanResultRequest : TeaModel {
        /// <summary>
        /// <para>The image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:6b0b094f8a904f8fb6602427aed0d1fa</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The query filter parameter. If the value is <c>FixCmd</c>, only the <c>FixCmd</c> result is returned, and other fields are not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixCmd</para>
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-2j88dtld8yel****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number of the scan result list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the scan result list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The image repository ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-uf082u9dg8do****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The image scan task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b0b094f-8a90-4f8f-b660-2427aed0****</para>
        /// </summary>
        [NameInMap("ScanTaskId")]
        [Validation(Required=false)]
        public string ScanTaskId { get; set; }

        /// <summary>
        /// <para>The vulnerability type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cve</c>: Image system vulnerability</description></item>
        /// <item><description><c>sca</c>: Image application vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The severity level of the scanned vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>High</c>: High</para>
        /// </description></item>
        /// <item><description><para><c>Medium</c>: Medium</para>
        /// </description></item>
        /// <item><description><para><c>Low</c>: Low</para>
        /// </description></item>
        /// <item><description><para><c>Unknown</c>: Unknown</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The image version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The fuzzy search keyword for scanning. Fuzzy match by CVE name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2021</para>
        /// </summary>
        [NameInMap("VulQueryKey")]
        [Validation(Required=false)]
        public string VulQueryKey { get; set; }

    }

}
