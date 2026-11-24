// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanMaliciousFileByTaskRequest : TeaModel {
        /// <summary>
        /// <para>The digest of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:aa4bffff6406785e930dab1f94c9a1297ba22xxxx71d71504a015764*********</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-gu94qynvpwk*****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The severity level of the malicious file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serious、suspicious、remind</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. If the value that you specify exceeds 100, the system returns a parameter error or uses 100 as the maximum number of entries to return.</para>
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
        /// <para>crr-h1y4l279wb8*****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The ID of the image scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79ee6bc2-3288-4c56-b967-**********</para>
        /// </summary>
        [NameInMap("ScanTaskId")]
        [Validation(Required=false)]
        public string ScanTaskId { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V6.11</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
