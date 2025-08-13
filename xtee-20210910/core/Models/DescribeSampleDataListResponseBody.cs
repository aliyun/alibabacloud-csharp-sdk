// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSampleDataListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSampleDataListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSampleDataListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Classification type, binary or multi-class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>二分类</para>
            /// </summary>
            [NameInMap("classificationType")]
            [Validation(Required=false)]
            public string ClassificationType { get; set; }

            /// <summary>
            /// <para>Criterion value for sample data calculation</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;正样本&quot;:&quot;1&quot;，&quot;负样本&quot;:&quot;1&quot;}</para>
            /// </summary>
            [NameInMap("dataDistributed")]
            [Validation(Required=false)]
            public string DataDistributed { get; set; }

            /// <summary>
            /// <para>First row of sample data. Used to define the values of each column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17700000000</para>
            /// </summary>
            [NameInMap("dataTitle")]
            [Validation(Required=false)]
            public string DataTitle { get; set; }

            /// <summary>
            /// <para>Deletion tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public string DeleteTag { get; set; }

            /// <summary>
            /// <para>Description information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Primary key ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>497</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册样本</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Number of normal samples</para>
            /// 
            /// <b>Example:</b>
            /// <para>999</para>
            /// </summary>
            [NameInMap("normalSize")]
            [Validation(Required=false)]
            public long? NormalSize { get; set; }

            /// <summary>
            /// <para>Recall configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;variables&quot;:&quot;a,b,c&quot;}</para>
            /// </summary>
            [NameInMap("recallConfig")]
            [Validation(Required=false)]
            public string RecallConfig { get; set; }

            /// <summary>
            /// <para>Number of risk samples</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("riskSize")]
            [Validation(Required=false)]
            public long? RiskSize { get; set; }

            /// <summary>
            /// <para>Specified risk value</para>
            /// 
            /// <b>Example:</b>
            /// <para>black</para>
            /// </summary>
            [NameInMap("riskValue")]
            [Validation(Required=false)]
            public string RiskValue { get; set; }

            /// <summary>
            /// <para>Sample label details</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;positive&quot;,&quot;size&quot;:&quot;2000&quot;,&quot;value&quot;:1},{&quot;type&quot;:&quot;negative&quot;,&quot;size&quot;:1900,&quot;value&quot;:0}]</para>
            /// </summary>
            [NameInMap("sampleLabelDetail")]
            [Validation(Required=false)]
            public string SampleLabelDetail { get; set; }

            /// <summary>
            /// <para>Sample size</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("sampleSize")]
            [Validation(Required=false)]
            public long? SampleSize { get; set; }

            /// <summary>
            /// <para>Scene code</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_abuse_detection</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>Status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Storage path</para>
            /// 
            /// <b>Example:</b>
            /// <para>saf/de/sample/3dc2spspHKq4G3YI9d08</para>
            /// </summary>
            [NameInMap("storePath")]
            [Validation(Required=false)]
            public string StorePath { get; set; }

            /// <summary>
            /// <para>Storage type</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("storeType")]
            [Validation(Required=false)]
            public string StoreType { get; set; }

            /// <summary>
            /// <para>Whether recall is supported</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportRecall")]
            [Validation(Required=false)]
            public string SupportRecall { get; set; }

            /// <summary>
            /// <para>User UID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1519714049632764</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>Version</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
