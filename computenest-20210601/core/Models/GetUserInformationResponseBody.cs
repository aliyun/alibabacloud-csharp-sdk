// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetUserInformationResponseBody : TeaModel {
        [NameInMap("DeliverySettings")]
        [Validation(Required=false)]
        public GetUserInformationResponseBodyDeliverySettings DeliverySettings { get; set; }
        public class GetUserInformationResponseBodyDeliverySettings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ActiontrailDeliveryToOssEnabled")]
            [Validation(Required=false)]
            public bool? ActiontrailDeliveryToOssEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0101data</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OssEnabled")]
            [Validation(Required=false)]
            public bool? OssEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("OssExpirationDays")]
            [Validation(Required=false)]
            public long? OssExpirationDays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>52EBAF16-22F6-53DB-AE1E-44764FC62AF0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
