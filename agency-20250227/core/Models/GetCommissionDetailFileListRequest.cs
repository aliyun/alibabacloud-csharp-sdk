// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCommissionDetailFileListRequest : TeaModel {
        /// <summary>
        /// <para>Billing month</para>
        /// 
        /// <b>Example:</b>
        /// <para>202501</para>
        /// </summary>
        [NameInMap("BillMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        /// <summary>
        /// <para>AccessKeyID used to upload files to OSS</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeyID</para>
        /// </summary>
        [NameInMap("OssAccessKeyId")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        /// <summary>
        /// <para>AccessKeySecret used to upload files to OSS</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeySecret</para>
        /// </summary>
        [NameInMap("OssAccessKeySecret")]
        [Validation(Required=false)]
        public string OssAccessKeySecret { get; set; }

        /// <summary>
        /// <para>OSS bucket</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourBucketName</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>Edge zone of the Region where the OSS bucket for file sharing is located</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss-cn-beijing.aliyuncs.com">http://oss-cn-beijing.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>Region to which the current OSS bucket belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegion")]
        [Validation(Required=false)]
        public string OssRegion { get; set; }

        /// <summary>
        /// <para>STS token used to upload files to OSS</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourSecurityToken</para>
        /// </summary>
        [NameInMap("OssSecurityToken")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

    }

}
