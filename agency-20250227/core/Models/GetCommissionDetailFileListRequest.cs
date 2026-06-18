// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCommissionDetailFileListRequest : TeaModel {
        /// <summary>
        /// <para>The billing month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202501</para>
        /// </summary>
        [NameInMap("BillMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        /// <summary>
        /// <para>The AccessKey ID used to upload files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeyID</para>
        /// </summary>
        [NameInMap("OssAccessKeyId")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret used to upload files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeySecret</para>
        /// </summary>
        [NameInMap("OssAccessKeySecret")]
        [Validation(Required=false)]
        public string OssAccessKeySecret { get; set; }

        /// <summary>
        /// <para>The OSS bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourBucketName</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The endpoint of the region where the Object Storage Service (OSS) bucket corresponding to the file sharing resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss-cn-beijing.aliyuncs.com">http://oss-cn-beijing.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The region where the OSS bucket resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegion")]
        [Validation(Required=false)]
        public string OssRegion { get; set; }

        /// <summary>
        /// <para>The STS token used to upload files to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourSecurityToken</para>
        /// </summary>
        [NameInMap("OssSecurityToken")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

    }

}
