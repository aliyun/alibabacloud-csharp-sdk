// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If the value of this parameter is not empty, more results are available. You can use this token in the next request to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of products.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// <para>The number of abnormal data ingestion configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AbnormalDataIngestionCount")]
            [Validation(Required=false)]
            public int? AbnormalDataIngestionCount { get; set; }

            /// <summary>
            /// <para>The activation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public long? ActiveTime { get; set; }

            /// <summary>
            /// <para>Indicates whether data collection configurations can be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowAddDataIngestion")]
            [Validation(Required=false)]
            public bool? AllowAddDataIngestion { get; set; }

            /// <summary>
            /// <para>The time when the product was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The data ingestion status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled.</para>
            /// </description></item>
            /// <item><description><para>false: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("DataIngestionStatus")]
            [Validation(Required=false)]
            public bool? DataIngestionStatus { get; set; }

            /// <summary>
            /// <para>The number of enabled data ingestion configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnabledDataIngestionCount")]
            [Validation(Required=false)]
            public int? EnabledDataIngestionCount { get; set; }

            /// <summary>
            /// <para>The product alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas</para>
            /// </summary>
            [NameInMap("ProductAlias")]
            [Validation(Required=false)]
            public string ProductAlias { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The product type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>preset</para>
            /// </description></item>
            /// <item><description><para>custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The total number of data ingestion configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalDataIngestionCount")]
            [Validation(Required=false)]
            public int? TotalDataIngestionCount { get; set; }

            /// <summary>
            /// <para>The time when the product was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The vendor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vd-qlsw5eocx94w9</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

            /// <summary>
            /// <para>The vendor name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
