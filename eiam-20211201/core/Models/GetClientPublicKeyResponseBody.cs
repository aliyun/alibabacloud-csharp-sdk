// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetClientPublicKeyResponseBody : TeaModel {
        [NameInMap("ClientPublicKey")]
        [Validation(Required=false)]
        public GetClientPublicKeyResponseBodyClientPublicKey ClientPublicKey { get; set; }
        public class GetClientPublicKeyResponseBodyClientPublicKey : TeaModel {
            /// <summary>
            /// <para>IDaaS EIAM 应用公私钥对算法类型 rsa2048、ecc256</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA-2048</para>
            /// </summary>
            [NameInMap("AlgorithmType")]
            [Validation(Required=false)]
            public string AlgorithmType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用公私钥对Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEYEqDnDJhztiEAwSin7MZoxGcihzCAuxxxx</para>
            /// </summary>
            [NameInMap("ClientPublicKeyId")]
            [Validation(Required=false)]
            public string ClientPublicKeyId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用公私钥对创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731305755000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1771305755000</para>
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用当前是否为首要使用的公私钥对</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Primary")]
            [Validation(Required=false)]
            public bool? Primary { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用公钥</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN PUBLIC KEY-----
            /// MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAmnWMdp9FU3vXljeIqpgR
            /// 05E6jEgzIfKsFaLkv+07e2Lg8luTaJh8Q2nkbxdNpTfqBnMMyTgml88WktP45F78
            /// La7hQtR3vz0Eu1yA92gXwD5Oob7ay4JYQZ0C80o2tB3FsbXG2jUvr31MNkf/0oBY
            /// qUKK5Hnlk1TdrnZ5VkzgLGHKlj+NJHHF/57DbT64C2qpAWeKHAr9umJ8++0hKqG/
            /// oRSOpb7oWK4t5c39ulp1j5JJ6cwqrKVCXvsHfWHywOHkcyus+ZNPTQvpwjRnEmRz
            /// Vy3NWrjT7JlIa8vS1aUU+FxeFd2MLQzxFxquFLwi05su2faRexaeYwWW6IWAI3tX
            /// twxxxxxx
            /// -----END PUBLIC KEY-----</para>
            /// </summary>
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 应用公私钥对状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
