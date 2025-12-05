// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeKeyVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the CMK version.</para>
        /// </summary>
        [NameInMap("KeyVersion")]
        [Validation(Required=false)]
        public DescribeKeyVersionResponseBodyKeyVersion KeyVersion { get; set; }
        public class DescribeKeyVersionResponseBodyKeyVersion : TeaModel {
            /// <summary>
            /// <para>The date and time when the CMK version was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-03-25T10:42:40Z</para>
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// <para>The globally unique ID of the CMK.</para>
            /// <remarks>
            /// <para> If you set the KeyId parameter in the request to an alias of the CMK, the ID of the CMK to which the alias is bound is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234abcd-12ab-34cd-56ef-12345678****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The globally unique ID of the CMK version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
            /// </summary>
            [NameInMap("KeyVersionId")]
            [Validation(Required=false)]
            public string KeyVersionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7021b6ec-4be7-4d3c-8a68-1e85d4d515a0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
