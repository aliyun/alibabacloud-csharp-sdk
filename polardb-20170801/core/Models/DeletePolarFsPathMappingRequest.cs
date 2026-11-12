// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeletePolarFsPathMappingRequest : TeaModel {
        /// <summary>
        /// <para>The bucket and corresponding path information. Usage notes: This parameter is required. You must provide at least one element, and each element must include Bucket (the OSS internal endpoint, in the format of {bucket}.oss-{regionId}-internal.aliyuncs.com) and Path. If this parameter is not provided or an empty array is provided, the API returns InvalidPolarFsPathList.Malformed (400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CustomBucketPathList")]
        [Validation(Required=false)]
        public List<DeletePolarFsPathMappingRequestCustomBucketPathList> CustomBucketPathList { get; set; }
        public class DeletePolarFsPathMappingRequestCustomBucketPathList : TeaModel {
            /// <summary>
            /// <para>The custom storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bucket</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The custom storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
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
