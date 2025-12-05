// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the version.</para>
        /// </summary>
        [NameInMap("KeyVersion")]
        [Validation(Required=false)]
        public CreateKeyVersionResponseBodyKeyVersion KeyVersion { get; set; }
        public class CreateKeyVersionResponseBodyKeyVersion : TeaModel {
            /// <summary>
            /// <para>The date and time when the version was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-02T10:38:27Z</para>
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// <para>The ID of the CMK. The ID must be globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0b30658a-ed1a-4922-b8f7-a673ca9c****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The ID of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0a3d5dc-0b47-4199-a050-b289349a****</para>
            /// </summary>
            [NameInMap("KeyVersionId")]
            [Validation(Required=false)]
            public string KeyVersionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b96f250a-4b75-498c-91be-22c6928f85be</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
