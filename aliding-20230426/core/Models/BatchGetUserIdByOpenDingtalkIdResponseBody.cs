// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class BatchGetUserIdByOpenDingtalkIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BatchGetUserIdByOpenDingtalkIdResponseBodyResults> Results { get; set; }
        public class BatchGetUserIdByOpenDingtalkIdResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>User.not.found</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DTOJdYJ2IQC4HuexhtjsS8Qxxxx</para>
            /// </summary>
            [NameInMap("OpenDingtalkId")]
            [Validation(Required=false)]
            public string OpenDingtalkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

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
