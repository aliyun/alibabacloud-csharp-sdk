// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBClusterStorageLimitationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBClusterStorageLimitationResponseBodyData Data { get; set; }
        public class DescribeDBClusterStorageLimitationResponseBodyData : TeaModel {
            [NameInMap("ClassCodeList")]
            [Validation(Required=false)]
            public List<DescribeDBClusterStorageLimitationResponseBodyDataClassCodeList> ClassCodeList { get; set; }
            public class DescribeDBClusterStorageLimitationResponseBodyDataClassCodeList : TeaModel {
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
                public int? CpuCores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DefaultStorageInGB")]
                [Validation(Required=false)]
                public int? DefaultStorageInGB { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MaxStorageInGB")]
                [Validation(Required=false)]
                public int? MaxStorageInGB { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MemoryInGB")]
                [Validation(Required=false)]
                public int? MemoryInGB { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinStorageInGB")]
                [Validation(Required=false)]
                public int? MinStorageInGB { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StepStorageInGB")]
                [Validation(Required=false)]
                public int? StepStorageInGB { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>An error occurred while processing your request.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4773E4EC-025D-509F-AEA9-D53123FDFB0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
