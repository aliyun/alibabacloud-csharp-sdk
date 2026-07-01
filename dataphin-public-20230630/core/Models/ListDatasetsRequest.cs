// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("DatasetQuery")]
        [Validation(Required=false)]
        public ListDatasetsRequestDatasetQuery DatasetQuery { get; set; }
        public class ListDatasetsRequestDatasetQuery : TeaModel {
            /// <summary>
            /// <para>The content type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The data domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74280</para>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

            /// <summary>
            /// <para>Specifies whether to include version details. Default value: FALSE.</para>
            /// </summary>
            [NameInMap("IncludeVersionList")]
            [Validation(Required=false)]
            public bool? IncludeVersionList { get; set; }

            /// <summary>
            /// <para>The keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001391</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7273382541481536</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The dataset scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OFFLINE: offline.</description></item>
            /// <item><description>REALTIME: real-time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001011</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The dataset type. If left empty, all types are queried.</para>
            /// </summary>
            [NameInMap("TypeList")]
            [Validation(Required=false)]
            public List<string> TypeList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
