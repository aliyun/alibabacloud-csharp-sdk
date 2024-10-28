// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListPublicDatasetResponseBody : TeaModel {
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<ListPublicDatasetResponseBodyDatasets> Datasets { get; set; }
        public class ListPublicDatasetResponseBodyDatasets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>This is description about dataset.</para>
            /// </summary>
            [NameInMap("About")]
            [Validation(Required=false)]
            public string About { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This are access requirements.</para>
            /// </summary>
            [NameInMap("AccessRequirements")]
            [Validation(Required=false)]
            public string AccessRequirements { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is copyright.</para>
            /// </summary>
            [NameInMap("Copyright")]
            [Validation(Required=false)]
            public string Copyright { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This are access requirements</para>
            /// </summary>
            [NameInMap("DatasetDescription")]
            [Validation(Required=false)]
            public string DatasetDescription { get; set; }

            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>西蒙斯基因组多样性计划</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy/MM/dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>源站更新后及时同步</para>
            /// </summary>
            [NameInMap("UpdateFrequency")]
            [Validation(Required=false)]
            public string UpdateFrequency { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ba6d88e2-a6f2-4d2c-a2ae-68b76b078445</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
