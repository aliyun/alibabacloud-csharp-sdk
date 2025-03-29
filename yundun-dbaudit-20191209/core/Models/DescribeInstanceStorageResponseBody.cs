// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20191209.Models
{
    public class DescribeInstanceStorageResponseBody : TeaModel {
        [NameInMap("InstanceStorages")]
        [Validation(Required=false)]
        public List<DescribeInstanceStorageResponseBodyInstanceStorages> InstanceStorages { get; set; }
        public class DescribeInstanceStorageResponseBodyInstanceStorages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6047313952768</para>
            /// </summary>
            [NameInMap("StorageCapacity")]
            [Validation(Required=false)]
            public long? StorageCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbaudit-audit-dbaudit-cn-78v1gc****</para>
            /// </summary>
            [NameInMap("StorageCategory")]
            [Validation(Required=false)]
            public string StorageCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbaudit-cn-78v1gc****</para>
            /// </summary>
            [NameInMap("StorageSpace")]
            [Validation(Required=false)]
            public string StorageSpace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("StorageTime")]
            [Validation(Required=false)]
            public long? StorageTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4226E2BB-EED8-4067-B31B-7F02966765B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
