// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyPolarFsMappingAuthRequest : TeaModel {
        /// <summary>
        /// <para>The bucket name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx.oss-[regionId]-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The AccessKey ID of the storage bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI5tExampleAccessKeyId</para>
        /// </summary>
        [NameInMap("BucketAccessKeyId")]
        [Validation(Required=false)]
        public string BucketAccessKeyId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret of the storage bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleAccessKeySecret1234567890</para>
        /// </summary>
        [NameInMap("BucketAccessKeySecret")]
        [Validation(Required=false)]
        public string BucketAccessKeySecret { get; set; }

        /// <summary>
        /// <para>The cluster ID. This parameter is required. If you do not provide this parameter, the service returns InvalidDBClusterId.Malformed. You can call DescribeDBClusters to query the cluster ID in the destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-******************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The destination path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

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
