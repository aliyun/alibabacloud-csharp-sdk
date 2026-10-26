// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataMaskingInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of records returned by the current query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListDataMaskingInstancesResponseBodyItems> Items { get; set; }
        public class ListDataMaskingInstancesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The current column encryption algorithm of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AES_256_GCM</para>
            /// </summary>
            [NameInMap("EncryptionAlgorithm")]
            [Validation(Required=false)]
            public string EncryptionAlgorithm { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used by the instance. This parameter may not be returned in local key scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-1234-1234-12345678****</para>
            /// </summary>
            [NameInMap("EncryptionKeyId")]
            [Validation(Required=false)]
            public string EncryptionKeyId { get; set; }

            /// <summary>
            /// <para>The type of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The number of database accounts that have the fullAccess plaintext access permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FullAccessAccountCount")]
            [Validation(Required=false)]
            public int? FullAccessAccountCount { get; set; }

            /// <summary>
            /// <para>The database instance identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1abcdefgh****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the cloud service type. Valid values: 5: RDS. 8: POLARDB. 27: PolarDBX2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Zhangjiakou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page in the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to locate the current API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the current statistics or query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
