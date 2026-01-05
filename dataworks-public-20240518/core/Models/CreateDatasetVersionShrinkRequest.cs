// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDatasetVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description for this dataset version. Maximum length: 1,024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The dataset ID. Currently supports DataWorks datasets only.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks-dataset:3pXXXb8o0ngr07njhps1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The storage import configuration for the dataset. Required configuration varies by storage type.</para>
        /// <para><b>NAS</b></para>
        /// <para>For valid values, see the response from the file storage API DescribeFileSystems.</para>
        /// <pre><code class="language-JSON">{
        /// &quot;fileSystemId&quot;: &quot;3b6XXX89c9&quot;, // The file system ID.
        /// &quot;fileSystemStorageType&quot;:  &quot;Performance&quot; // The file system storage type.
        /// &quot;vpcId&quot;: &quot;vpc-uf66oxxxrqge1t2gson7s&quot; // The VPC ID for the mount point.
        /// }
        /// </c></pre>
        /// </summary>
        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public string ImportInfoShrink { get; set; }

        /// <summary>
        /// <para>The mount path, which must start with /mnt/. Default value: /mnt/data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>URL</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-oss-bucket/test_dir/</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
