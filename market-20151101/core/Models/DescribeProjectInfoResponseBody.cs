// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ee3e1b3b-6c38-4bcf-be40-5a946cfda761</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeProjectInfoResponseBodyResult Result { get; set; }
        public class DescribeProjectInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CurrentStepNo")]
            [Validation(Required=false)]
            public int? CurrentStepNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27291111****</para>
            /// </summary>
            [NameInMap("CustomerAliUid")]
            [Validation(Required=false)]
            public long? CustomerAliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("FinalStepNo")]
            [Validation(Required=false)]
            public int? FinalStepNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("FinishType")]
            [Validation(Required=false)]
            public string FinishType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1588834324000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620403200000</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public long? GmtExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620403200000</para>
            /// </summary>
            [NameInMap("GmtFinished")]
            [Validation(Required=false)]
            public long? GmtFinished { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4****89</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2059111111111</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cmgj***055</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yuncode****500001</para>
            /// </summary>
            [NameInMap("ProductSkuCode")]
            [Validation(Required=false)]
            public string ProductSkuCode { get; set; }

            [NameInMap("ProductSkuName")]
            [Validation(Required=false)]
            public string ProductSkuName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Starting</para>
            /// </summary>
            [NameInMap("ProjectStatus")]
            [Validation(Required=false)]
            public string ProjectStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>45121111****</para>
            /// </summary>
            [NameInMap("SupplierAliUid")]
            [Validation(Required=false)]
            public long? SupplierAliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>410</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
