// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateAccessKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the AccessKey pair.</para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public CreateAccessKeyResponseBodyAccessKey AccessKey { get; set; }
        public class CreateAccessKeyResponseBodyAccessKey : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0wNEpMMlzy7s****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PupkTg8jdmau1cXxYacgE736PJ****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey pair was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The status of the AccessKey pair. Valid values: Active and Inactive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
