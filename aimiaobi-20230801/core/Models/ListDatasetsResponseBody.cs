// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListDatasetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CustomSemanticSearchConfig")]
        [Validation(Required=false)]
        public ListDatasetsResponseBodyCustomSemanticSearchConfig CustomSemanticSearchConfig { get; set; }
        public class ListDatasetsResponseBodyCustomSemanticSearchConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DatasetQuota")]
            [Validation(Required=false)]
            public int? DatasetQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DatasetUsedQuota")]
            [Validation(Required=false)]
            public int? DatasetUsedQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("DocQuota")]
            [Validation(Required=false)]
            public long? DocQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DocUsedQuota")]
            [Validation(Required=false)]
            public long? DocUsedQuota { get; set; }

        }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDatasetsResponseBodyData> Data { get; set; }
        public class ListDatasetsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-12 21:46:24</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("DatasetDescription")]
            [Validation(Required=false)]
            public string DatasetDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public long? DatasetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CustomSemanticSearch</para>
            /// </summary>
            [NameInMap("DatasetType")]
            [Validation(Required=false)]
            public string DatasetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DocUsedQuota")]
            [Validation(Required=false)]
            public long? DocUsedQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SearchDatasetEnable")]
            [Validation(Required=false)]
            public int? SearchDatasetEnable { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ThirdSearchConfig")]
        [Validation(Required=false)]
        public ListDatasetsResponseBodyThirdSearchConfig ThirdSearchConfig { get; set; }
        public class ListDatasetsResponseBodyThirdSearchConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatasetQuota")]
            [Validation(Required=false)]
            public int? DatasetQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DatasetUsedQuota")]
            [Validation(Required=false)]
            public int? DatasetUsedQuota { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
