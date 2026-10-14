// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAgenticSqlExecuteCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The temporary credential information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAgenticSqlExecuteCredentialResponseBodyData Data { get; set; }
        public class CreateAgenticSqlExecuteCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey of the credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_xxxxxxxx</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the credential. This value is returned only once when the credential is created. Keep it secure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx</para>
            /// </summary>
            [NameInMap("AccessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1xxxxxxxx</para>
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// <para>The UUID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9f8e7d6c-xxxx-xxxx-xxxx-1a2b3c4d5e6f</para>
            /// </summary>
            [NameInMap("CatalogUuid")]
            [Validation(Required=false)]
            public string CatalogUuid { get; set; }

            /// <summary>
            /// <para>The UUID of the database. If the credential is at the instance level, this value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6c4e8a2b-xxxx-xxxx-xxxx-0f1d2e3c4b5a</para>
            /// </summary>
            [NameInMap("DatabaseUuid")]
            [Validation(Required=false)]
            public string DatabaseUuid { get; set; }

            /// <summary>
            /// <para>The expiration time of the credential. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13 12:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The total number of connections supported by the credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MaxConnectTimes")]
            [Validation(Required=false)]
            public long? MaxConnectTimes { get; set; }

            /// <summary>
            /// <para>The fully qualified name of the database. If the credential is at the instance level, this value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("QualifiedName")]
            [Validation(Required=false)]
            public string QualifiedName { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_PARAMETER</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34E01EDD-6A16-4CF0-9541-C644D1BE01AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.                                 </description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
