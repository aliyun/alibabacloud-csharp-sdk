// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferInListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTransferInListResponseBodyData Data { get; set; }
        public class QueryTransferInListResponseBodyData : TeaModel {
            [NameInMap("TransferInInfo")]
            [Validation(Required=false)]
            public List<QueryTransferInListResponseBodyDataTransferInInfo> TransferInInfo { get; set; }
            public class QueryTransferInListResponseBodyDataTransferInInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-28 00:41:42</para>
                /// </summary>
                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1514428524669</para>
                /// </summary>
                [NameInMap("ExpirationDateLong")]
                [Validation(Required=false)]
                public long? ExpirationDateLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>S20181T0WLI85212</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-28 00:41:42</para>
                /// </summary>
                [NameInMap("ModificationDate")]
                [Validation(Required=false)]
                public string ModificationDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1514428524669</para>
                /// </summary>
                [NameInMap("ModificationDateLong")]
                [Validation(Required=false)]
                public long? ModificationDateLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NeedMailCheck")]
                [Validation(Required=false)]
                public bool? NeedMailCheck { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ProgressBarType")]
                [Validation(Required=false)]
                public int? ProgressBarType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>clientCancelled</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-28 00:41:42</para>
                /// </summary>
                [NameInMap("ResultDate")]
                [Validation(Required=false)]
                public string ResultDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1514428524669</para>
                /// </summary>
                [NameInMap("ResultDateLong")]
                [Validation(Required=false)]
                public long? ResultDateLong { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FAIL</para>
                /// </summary>
                [NameInMap("SimpleTransferInStatus")]
                [Validation(Required=false)]
                public string SimpleTransferInStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-28 00:41:42</para>
                /// </summary>
                [NameInMap("SubmissionDate")]
                [Validation(Required=false)]
                public string SubmissionDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1514428524669</para>
                /// </summary>
                [NameInMap("SubmissionDateLong")]
                [Validation(Required=false)]
                public long? SubmissionDateLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-03-28 00:41:42</para>
                /// </summary>
                [NameInMap("TransferAuthorizationCodeSubmissionDate")]
                [Validation(Required=false)]
                public string TransferAuthorizationCodeSubmissionDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1514428524669</para>
                /// </summary>
                [NameInMap("TransferAuthorizationCodeSubmissionDateLong")]
                [Validation(Required=false)]
                public long? TransferAuthorizationCodeSubmissionDateLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("WhoisMailStatus")]
                [Validation(Required=false)]
                public bool? WhoisMailStatus { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
