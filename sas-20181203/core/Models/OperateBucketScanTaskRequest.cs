// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateBucketScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The bucket name.</para>
        /// <remarks>
        /// <para>Note: This parameter is required. If this parameter is not specified, the API returns the InvalidBucketName (400) error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>iboxpublic****</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The operation to perform on the bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Cancel the scan task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OperateCode")]
        [Validation(Required=false)]
        public int? OperateCode { get; set; }

        /// <summary>
        /// <para>The business source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS</description></item>
        /// <item><description><b>NAS</b>: NAS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
