// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("InstanceItems")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstanceItems InstanceItems { get; set; }
        public class DescribeInstancesResponseBodyInstanceItems : TeaModel {
            [NameInMap("InstanceItem")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstanceItemsInstanceItem> InstanceItem { get; set; }
            public class DescribeInstancesResponseBodyInstanceItemsInstanceItem : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ApiJson")]
                [Validation(Required=false)]
                public string ApiJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;frontEndUrl&quot;:&quot;https://<em><b>.aliyun.com&quot;,&quot;password&quot;:&quot;Sjtv</b></em>&quot;,&quot;adminUrl&quot;:&quot;https://<em><b>.aiiyun.com&quot;,&quot;username&quot;:&quot;aliyun</b></em>&quot;}</para>
                /// </summary>
                [NameInMap("AppJson")]
                [Validation(Required=false)]
                public string AppJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1570634021000</para>
                /// </summary>
                [NameInMap("BeganOn")]
                [Validation(Required=false)]
                public long? BeganOn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1570634021000</para>
                /// </summary>
                [NameInMap("CreatedOn")]
                [Validation(Required=false)]
                public long? CreatedOn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1570644021000</para>
                /// </summary>
                [NameInMap("EndOn")]
                [Validation(Required=false)]
                public long? EndOn { get; set; }

                [NameInMap("ExtendJson")]
                [Validation(Required=false)]
                public string ExtendJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;password&quot;:&quot;<em><b>&quot;,&quot;ip&quot;:&quot;118.31.</b></em>.41&quot;,&quot;innerIp&quot;:&quot;118.31.<em><b>.41&quot;,&quot;region&quot;:&quot;&quot;,&quot;username&quot;:&quot;</b></em>&quot;,&quot;beianInfo&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("HostJson")]
                [Validation(Required=false)]
                public string HostJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("IdaasJson")]
                [Validation(Required=false)]
                public string IdaasJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ImageJson")]
                [Validation(Required=false)]
                public string ImageJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1551111111</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>204211111111111</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cmgj00**11</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cmgj00**11-prepay</para>
                /// </summary>
                [NameInMap("ProductSkuCode")]
                [Validation(Required=false)]
                public string ProductSkuCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>APP</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OPENED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

            }

        }

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
        /// <para>54C22FB9-0CB1-5629-97A8-653FC7990F00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
