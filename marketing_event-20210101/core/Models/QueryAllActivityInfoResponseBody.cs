// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class QueryAllActivityInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAllActivityInfoResponseBodyData> Data { get; set; }
        public class QueryAllActivityInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public long? ActivityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vip</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CustomerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xx@aliyun.com">xx@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsVipCustomer")]
            [Validation(Required=false)]
            public string IsVipCustomer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12123455</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("QRCode")]
            [Validation(Required=false)]
            public string QRCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ReportFields")]
            [Validation(Required=false)]
            public string ReportFields { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

    }

}
