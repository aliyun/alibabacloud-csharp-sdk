// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateBucketScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iboxpublic****</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on the bucket. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: cancels the bucket check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OperateCode")]
        [Validation(Required=false)]
        public int? OperateCode { get; set; }

    }

}
