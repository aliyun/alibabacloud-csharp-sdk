// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDatasetVersionRequest : TeaModel {
        /// <summary>
        /// <para>The description of the dataset version. The length cannot exceed 1,024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the dataset. Currently, only DataWorks datasets are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks-dataset:3pXXXb8o0ngr07njhps1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The storage import configuration of the dataset. The required configuration information varies based on the storage type.</para>
        /// <details>
        /// <summary>NAS</summary>
        /// For valid values, refer to the response of the DescribeFileSystems operation in the File Storage NAS API documentation.
        /// 
        /// <pre><code class="language-JSON">{
        ///   &quot;fileSystemId&quot;: &quot;3b6XXX89c9&quot;, // The ID of the file system.
        ///   &quot;fileSystemStorageType&quot;: &quot;Performance&quot;, // The storage specification of the file system.
        ///   &quot;vpcId&quot;: &quot;vpc-uf66oxxxrqge1t2gson7s&quot; // The VPC ID of the mount target.
        /// }
        /// </c></pre>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fileSystemId&quot;:&quot;3b6XXX89c9&quot;,&quot;fileSystemStorageType&quot;:&quot;Performance&quot;,&quot;vpcId&quot;:&quot;vpc-uf66oxxxrqge1t2gson7s&quot;}</para>
        /// </summary>
        [NameInMap("ImportInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> ImportInfo { get; set; }

        /// <summary>
        /// <para>The mount path. It must start with /mnt/. Default value: /mnt/data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>The URL.</para>
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
