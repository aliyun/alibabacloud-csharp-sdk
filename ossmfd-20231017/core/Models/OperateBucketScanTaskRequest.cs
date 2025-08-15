// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssMfd20231017.Models
{
    public class OperateBucketScanTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testBucket******</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OperateCode")]
        [Validation(Required=false)]
        public int? OperateCode { get; set; }

    }

}
