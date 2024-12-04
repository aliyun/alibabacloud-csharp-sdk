// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateOSSHDFSExportRequest : TeaModel {
        /// <summary>
        /// <para>The configuration details of the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public OSSExportConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the job.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-oss-hdfs-job</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the OSS data shipping job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-123456789-123456</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
