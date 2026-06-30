// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetDingtalkProjectionListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDingtalkProjectionListResponseBodyData> Data { get; set; }
        public class GetDingtalkProjectionListResponseBodyData : TeaModel {
            [NameInMap("callStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("devUid")]
            [Validation(Required=false)]
            public long? DevUid { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("endTs")]
            [Validation(Required=false)]
            public long? EndTs { get; set; }

            [NameInMap("nickCode")]
            [Validation(Required=false)]
            public string NickCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("orgId")]
            [Validation(Required=false)]
            public long? OrgId { get; set; }

            [NameInMap("recvClientId")]
            [Validation(Required=false)]
            public string RecvClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("recvClientName")]
            [Validation(Required=false)]
            public string RecvClientName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>room001</para>
            /// </summary>
            [NameInMap("sendClientId")]
            [Validation(Required=false)]
            public string SendClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("sendClientName")]
            [Validation(Required=false)]
            public string SendClientName { get; set; }

            [NameInMap("sendClientWorkNo")]
            [Validation(Required=false)]
            public string SendClientWorkNo { get; set; }

            [NameInMap("startTs")]
            [Validation(Required=false)]
            public long? StartTs { get; set; }

            [NameInMap("timeStr")]
            [Validation(Required=false)]
            public string TimeStr { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
