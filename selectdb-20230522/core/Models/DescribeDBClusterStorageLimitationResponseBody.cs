// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBClusterStorageLimitationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial. This field is returned only when the RAM verification fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBClusterStorageLimitationResponseBodyData Data { get; set; }
        public class DescribeDBClusterStorageLimitationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of cache specifications.</para>
            /// </summary>
            [NameInMap("ClassCodeList")]
            [Validation(Required=false)]
            public List<DescribeDBClusterStorageLimitationResponseBodyDataClassCodeList> ClassCodeList { get; set; }
            public class DescribeDBClusterStorageLimitationResponseBodyDataClassCodeList : TeaModel {
                /// <summary>
                /// <para>The specification code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>selectdb.xlarge</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                /// <summary>
                /// <para>The number of vCPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public int? CpuCores { get; set; }

                /// <summary>
                /// <para>The default cache size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DefaultStorageInGB")]
                [Validation(Required=false)]
                public int? DefaultStorageInGB { get; set; }

                /// <summary>
                /// <para>The maximum cache size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MaxStorageInGB")]
                [Validation(Required=false)]
                public int? MaxStorageInGB { get; set; }

                /// <summary>
                /// <para>The memory size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MemoryInGB")]
                [Validation(Required=false)]
                public int? MemoryInGB { get; set; }

                /// <summary>
                /// <para>The minimum cache size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinStorageInGB")]
                [Validation(Required=false)]
                public int? MinStorageInGB { get; set; }

                /// <summary>
                /// <para>The cache step size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StepStorageInGB")]
                [Validation(Required=false)]
                public int? StepStorageInGB { get; set; }

            }

        }

        /// <summary>
        /// <para>The dynamic code. This parameter is not used. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is not used. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An error occurred while processing your request.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4773E4EC-025D-509F-AEA9-D53123FDFB0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
