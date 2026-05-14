// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListPolarClawDevicePairsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Paired")]
        [Validation(Required=false)]
        public List<ListPolarClawDevicePairsResponseBodyPaired> Paired { get; set; }
        public class ListPolarClawDevicePairsResponseBodyPaired : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cli</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cli</para>
            /// </summary>
            [NameInMap("ClientMode")]
            [Validation(Required=false)]
            public string ClientMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1778659807727</para>
            /// </summary>
            [NameInMap("CreatedAtMs")]
            [Validation(Required=false)]
            public long? CreatedAtMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("DeviceFamily")]
            [Validation(Required=false)]
            public string DeviceFamily { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f92620d6bea04f65d48cf603c57b367c97e837c1ab9f6d78f741f477e99d857c</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1778659807727</para>
            /// </summary>
            [NameInMap("LastSeenAtMs")]
            [Validation(Required=false)]
            public long? LastSeenAtMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<string> Scopes { get; set; }

        }

        [NameInMap("Pending")]
        [Validation(Required=false)]
        public List<ListPolarClawDevicePairsResponseBodyPending> Pending { get; set; }
        public class ListPolarClawDevicePairsResponseBodyPending : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cli</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cli</para>
            /// </summary>
            [NameInMap("ClientMode")]
            [Validation(Required=false)]
            public string ClientMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>server</para>
            /// </summary>
            [NameInMap("DeviceFamily")]
            [Validation(Required=false)]
            public string DeviceFamily { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>device-784x37k0vko734fk</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsRepair")]
            [Validation(Required=false)]
            public bool? IsRepair { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-1778647932986</para>
            /// </summary>
            [NameInMap("PairRequestId")]
            [Validation(Required=false)]
            public string PairRequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-pubkey-base64url</para>
            /// </summary>
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("RemoteIp")]
            [Validation(Required=false)]
            public string RemoteIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<string> Scopes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Silent")]
            [Validation(Required=false)]
            public bool? Silent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1778660347550</para>
            /// </summary>
            [NameInMap("Ts")]
            [Validation(Required=false)]
            public long? Ts { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
