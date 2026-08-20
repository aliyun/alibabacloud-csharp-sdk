// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ee3e1b3b-6c38-4bcf-be40-5a946cfda761</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeProjectInfoResponseBodyResult Result { get; set; }
        public class DescribeProjectInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The current step in the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CurrentStepNo")]
            [Validation(Required=false)]
            public int? CurrentStepNo { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27291111****</para>
            /// </summary>
            [NameInMap("CustomerAliUid")]
            [Validation(Required=false)]
            public long? CustomerAliUid { get; set; }

            /// <summary>
            /// <para>The sequence number of the last step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("FinalStepNo")]
            [Validation(Required=false)]
            public int? FinalStepNo { get; set; }

            /// <summary>
            /// <para>The completion method of the project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>null: The default value for unfinished projects.</description></item>
            /// <item><description>CustomerConfirm: Manually confirmed by the customer.</description></item>
            /// <item><description>SystemAutoConfirm: Automatically confirmed by the system due to timeout.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("FinishType")]
            [Validation(Required=false)]
            public string FinishType { get; set; }

            /// <summary>
            /// <para>The creation time of the project. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588834324000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The expiration time of the project. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620403200000</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public long? GmtExpired { get; set; }

            /// <summary>
            /// <para>The completion time of the project. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620403200000</para>
            /// </summary>
            [NameInMap("GmtFinished")]
            [Validation(Required=false)]
            public long? GmtFinished { get; set; }

            /// <summary>
            /// <para>The business instance ID in Cloud Marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4****89</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2059111111111</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmgj***055</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The name of the Cloud Marketplace product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>公司宝****记账</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The code of the Cloud Marketplace product SKU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yuncode****500001</para>
            /// </summary>
            [NameInMap("ProductSkuCode")]
            [Validation(Required=false)]
            public string ProductSkuCode { get; set; }

            /// <summary>
            /// <para>The name of the Cloud Marketplace product SKU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小***纳税人</para>
            /// </summary>
            [NameInMap("ProductSkuName")]
            [Validation(Required=false)]
            public string ProductSkuName { get; set; }

            /// <summary>
            /// <para>The execution status of the project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Starting: In progress.</description></item>
            /// <item><description>Cancel: Canceled.</description></item>
            /// <item><description>Pause: Paused.</description></item>
            /// <item><description>Finish: Completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Starting</para>
            /// </summary>
            [NameInMap("ProjectStatus")]
            [Validation(Required=false)]
            public string ProjectStatus { get; set; }

            /// <summary>
            /// <para>The UID of the supplier to which the project belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45121111****</para>
            /// </summary>
            [NameInMap("SupplierAliUid")]
            [Validation(Required=false)]
            public long? SupplierAliUid { get; set; }

            /// <summary>
            /// <para>The ID of the process template to which the project belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>410</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The template type of the project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Public: Public template.</description></item>
            /// <item><description>Private: Private template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
