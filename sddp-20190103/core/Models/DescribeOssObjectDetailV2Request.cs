// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailV2Request : TeaModel {
        /// <summary>
        /// <para>Bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sddp-api-scan-demo</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The unique identifier ID of the OSS storage object.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/410152.html">DescribeOssObjects</a> interface to get the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12300</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Sets the language type for request and response messages. The default value is <b>zh_cn</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese</description></item>
        /// <item><description><b>en_us</b>: English (US)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The full file name of the file stored on OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir1/test.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>Service region ID, i.e., the region ID where the Bucket is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>Industry template ID.</para>
        /// <remarks>
        /// <para>You can obtain the industry template ID by calling the <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
