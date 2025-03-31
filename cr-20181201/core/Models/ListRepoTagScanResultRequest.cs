// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagScanResultRequest : TeaModel {
        /// <summary>
        /// <para>The digest of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:6b0b094f8a904f8fb6602427aed0d1fa</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The parameter whose value that you want to query. Fox example, if the value is <c>FixCmd</c>, only the <c>FixCmd</c> parameter is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixCmd</para>
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-2j88dtld8yel****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-uf082u9dg8do****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The ID of the security scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b0b094f-8a90-4f8f-b660-2427aed0****</para>
        /// </summary>
        [NameInMap("ScanTaskId")]
        [Validation(Required=false)]
        public string ScanTaskId { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>cve</c>: image system vulnerability</description></item>
        /// <item><description><c>sca</c>: image application vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The severity of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>High</c></description></item>
        /// <item><description><c>Medium</c></description></item>
        /// <item><description><c>Low</c></description></item>
        /// <item><description><c>Unknown</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The name of the image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy search used in scanning. The value can be a CVE name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2021</para>
        /// </summary>
        [NameInMap("VulQueryKey")]
        [Validation(Required=false)]
        public string VulQueryKey { get; set; }

    }

}
