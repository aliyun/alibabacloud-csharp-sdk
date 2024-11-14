// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeAllDBInstanceClassResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance specifications.</para>
        /// </summary>
        [NameInMap("ClassCodeList")]
        [Validation(Required=false)]
        public List<DescribeAllDBInstanceClassResponseBodyClassCodeList> ClassCodeList { get; set; }
        public class DescribeAllDBInstanceClassResponseBodyClassCodeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb.xlarge</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public long? CpuCores { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("DefaultStorageInGB")]
            [Validation(Required=false)]
            public long? DefaultStorageInGB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("MaxStorageInGB")]
            [Validation(Required=false)]
            public long? MaxStorageInGB { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("MemoryInGB")]
            [Validation(Required=false)]
            public long? MemoryInGB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MinStorageInGB")]
            [Validation(Required=false)]
            public long? MinStorageInGB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StepStorageInGB")]
            [Validation(Required=false)]
            public long? StepStorageInGB { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4773E4EC-025D-509F-AEA9-D53123FDFB0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
