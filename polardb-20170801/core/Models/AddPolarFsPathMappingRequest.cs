// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddPolarFsPathMappingRequest : TeaModel {
        /// <summary>
        /// <para>The bucket and corresponding path information.</para>
        /// </summary>
        [NameInMap("CustomBucketPathList")]
        [Validation(Required=false)]
        public List<AddPolarFsPathMappingRequestCustomBucketPathList> CustomBucketPathList { get; set; }
        public class AddPolarFsPathMappingRequestCustomBucketPathList : TeaModel {
            /// <summary>
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bucket1</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The AccessKey ID for the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAIExampleBucketAccessKeyId</para>
            /// </summary>
            [NameInMap("BucketAccessKeyId")]
            [Validation(Required=false)]
            public string BucketAccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret for the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleBucketAccessKeySecret123</para>
            /// </summary>
            [NameInMap("BucketAccessKeySecret")]
            [Validation(Required=false)]
            public string BucketAccessKeySecret { get; set; }

            /// <summary>
            /// <para>The custom storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data1</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The PolarFS instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

    }

}
