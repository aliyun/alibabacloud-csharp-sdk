// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
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
            /// <para>LTAI4G3HaMmeHpay2gcq****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y3MSLE6OgizS4qrz5LVFDoyZEL****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey pair was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-15T08:08:54Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The status of the AccessKey pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active</description></item>
            /// <item><description>Inactive</description></item>
            /// </list>
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
        /// <para>19DDD9F7-AFCC-4D72-8CBA-CCE5A142E7AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
