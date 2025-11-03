// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>not_authorized</description></item>
        /// <item><description>authorized</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>authorized</para>
        /// </summary>
        [NameInMap("AuthorizeStatus")]
        [Validation(Required=false)]
        public string AuthorizeStatus { get; set; }

        /// <summary>
        /// <para>Customer master key (CMK)</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<DescribeKmsKeysResponseBodyKeys> Keys { get; set; }
        public class DescribeKmsKeysResponseBodyKeys : TeaModel {
            /// <summary>
            /// <para>The alias of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestAlias</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the key in KMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:kms:cn-hangzhou:154035569884****:key/05754286-3ba2-4fa6-8d41-4323aca6****</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The ID of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05754286-3ba2-4fa6-8d41-4323aca6****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The type of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceKey</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether KMS is activated.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>disabled</description></item>
        /// <item><description>enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("KmsServiceStatus")]
        [Validation(Required=false)]
        public string KmsServiceStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
