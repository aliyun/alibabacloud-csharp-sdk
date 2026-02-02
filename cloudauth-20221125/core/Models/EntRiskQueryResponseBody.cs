// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntRiskQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. For details about error codes, see <b><a href="https://help.aliyun.com/document_detail/215420.html">Error Codes</a></b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response message for the request information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public EntRiskQueryResponseBodyResult Result { get; set; }
        public class EntRiskQueryResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Query result
            /// 0: Normal business operation
            /// 1: Abnormal business operation
            /// 2: Not found</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>List of abnormal information</para>
            /// </summary>
            [NameInMap("RiskList")]
            [Validation(Required=false)]
            public List<EntRiskQueryResponseBodyResultRiskList> RiskList { get; set; }
            public class EntRiskQueryResponseBodyResultRiskList : TeaModel {
                /// <summary>
                /// <para>Unified Social Credit Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>92500112MA5UHU****</para>
                /// </summary>
                [NameInMap("CreditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                /// <summary>
                /// <para>Company name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州****</para>
                /// </summary>
                [NameInMap("EntName")]
                [Validation(Required=false)]
                public string EntName { get; set; }

                /// <summary>
                /// <para>Date listed as abnormal
                /// Example: 2023-02-03</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-03</para>
                /// </summary>
                [NameInMap("ListedDate")]
                [Validation(Required=false)]
                public string ListedDate { get; set; }

                /// <summary>
                /// <para>Reason for being listed as abnormal</para>
                /// 
                /// <b>Example:</b>
                /// <para>未按照《个体工商户年度报告暂行办法》***</para>
                /// </summary>
                [NameInMap("ListedReason")]
                [Validation(Required=false)]
                public string ListedReason { get; set; }

                /// <summary>
                /// <para>Authority that handled the inclusion</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>市场监督</b></em></para>
                /// </summary>
                [NameInMap("OperationOrg")]
                [Validation(Required=false)]
                public string OperationOrg { get; set; }

                /// <summary>
                /// <para>Business registration number</para>
                /// 
                /// <b>Example:</b>
                /// <para>50011260996****</para>
                /// </summary>
                [NameInMap("RegNo")]
                [Validation(Required=false)]
                public string RegNo { get; set; }

                /// <summary>
                /// <para>Date removed from the abnormal list
                /// Example: 2023-02-03</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-06</para>
                /// </summary>
                [NameInMap("RemovedDate")]
                [Validation(Required=false)]
                public string RemovedDate { get; set; }

                /// <summary>
                /// <para>Authority that handled the removal</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b>市场监督</b></em></para>
                /// </summary>
                [NameInMap("RemovedOrg")]
                [Validation(Required=false)]
                public string RemovedOrg { get; set; }

                /// <summary>
                /// <para>Reason for being removed from the abnormal list</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据《个体工商户年度报告暂行办法》第十三条的规定******</para>
                /// </summary>
                [NameInMap("RemovedReason")]
                [Validation(Required=false)]
                public string RemovedReason { get; set; }

            }

            /// <summary>
            /// <para>Business operation status.</para>
            /// <list type="bullet">
            /// <item><description>1: In operation (open)</description></item>
            /// <item><description>2: Relocated</description></item>
            /// <item><description>3: Deregistered</description></item>
            /// <item><description>4: Revoked</description></item>
            /// <item><description>5: Canceled</description></item>
            /// <item><description>6: Suspended</description></item>
            /// <item><description>0: Other</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
