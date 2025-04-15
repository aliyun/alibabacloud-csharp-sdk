// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>67bfbcc12b67936ec7f867927817cbb071832b873dbcaed312a1930ba5f1d529</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-2j88dtld8yel****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crr-uf082u9dg8do****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>838152F9-F725-5A52-A344-8972D65AC045</para>
        /// </summary>
        [NameInMap("ScanTaskId")]
        [Validation(Required=false)]
        public string ScanTaskId { get; set; }

        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
