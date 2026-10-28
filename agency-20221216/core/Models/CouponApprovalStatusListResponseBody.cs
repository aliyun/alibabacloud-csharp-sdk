// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CouponApprovalStatusListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CouponApprovalStatusListResponseBodyData> Data { get; set; }
        public class CouponApprovalStatusListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The issuing account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("IssuerAccount")]
            [Validation(Required=false)]
            public string IssuerAccount { get; set; }

            /// <summary>
            /// <para>The UID of the issuing account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432738203821334</para>
            /// </summary>
            [NameInMap("IssuerUid")]
            [Validation(Required=false)]
            public string IssuerUid { get; set; }

            /// <summary>
            /// <para>The approval comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approved</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S00000101-100040</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the coupon template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template name</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The status of the coupon template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: application revoked</description></item>
            /// <item><description><b>2</b>: under review</description></item>
            /// <item><description><b>3</b>: review rejected</description></item>
            /// <item><description><b>4</b>: review approved</description></item>
            /// <item><description><b>5</b>: review approved but issuance failed</description></item>
            /// <item><description><b>6</b>: automatically approved</description></item>
            /// <item><description><b>7</b>: automatically approved but issuance failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public long? TemplateStatus { get; set; }

            /// <summary>
            /// <para>The application time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-02 09:46:59</para>
            /// </summary>
            [NameInMap("TimeOfRequest")]
            [Validation(Required=false)]
            public string TimeOfRequest { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
