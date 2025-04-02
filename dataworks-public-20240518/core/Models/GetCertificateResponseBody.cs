// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the certificate file.</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public GetCertificateResponseBodyCertificate Certificate { get; set; }
        public class GetCertificateResponseBodyCertificate : TeaModel {
            /// <summary>
            /// <para>The time when the certificate file was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730217600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the certificate file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1107550004253538</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a file</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The size of the certificate file, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77549</para>
            /// </summary>
            [NameInMap("FileSizeInBytes")]
            [Validation(Required=false)]
            public long? FileSizeInBytes { get; set; }

            /// <summary>
            /// <para>The ID of the certificate file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>676303114031776</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the certificate file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca1.crt</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the certificate file belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177161</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
