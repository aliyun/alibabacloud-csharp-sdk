// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UploadFileAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The type of the purge or prefetch task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>file</b> (default): purges the cache by file.</description></item>
        /// <item><description><b>preload</b>: prefetches the file.</description></item>
        /// <item><description><b>directory</b>: purges the cache by directory.</description></item>
        /// <item><description><b>ignoreParams</b>: purges the cache by URL with specified parameters ignored.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The name of the upload task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>purge_task_2024_11_11</para>
        /// </summary>
        [NameInMap("UploadTaskName")]
        [Validation(Required=false)]
        public string UploadTaskName { get; set; }

        /// <summary>
        /// <para>The OSS URL of the file that contains resources to be purged or prefetched.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxx.oss-cn-shenzhen.aliyuncs.com/test_oss_file?Expires=1708659191&OSSAccessKeyId=**********&Signature=">https://xxxxx.oss-cn-shenzhen.aliyuncs.com/test_oss_file?Expires=1708659191&amp;OSSAccessKeyId=**********&amp;Signature=</a>**********</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public Stream UrlObject { get; set; }

    }

}
