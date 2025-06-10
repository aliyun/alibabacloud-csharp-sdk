// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoTagScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The digest of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:815386ebbe9a3490f38785ab11bda34ec8dacf4634af77b8912832d4f85dca04</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-xwvi3osiy4ff****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The type of the scanning engine.</para>
        /// <list type="bullet">
        /// <item><description><c>SAS_SCAN_SERVICE</c>: Security Center scan engine (paid service)</description></item>
        /// <item><description><c>ACR_SCAN_SERVICE</c>: Container Registry scan engine</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACR_SCAN_SERVICE</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.24</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
