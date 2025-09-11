// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeInstanceAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>API Keys</para>
        /// </summary>
        [NameInMap("ApiKeys")]
        [Validation(Required=false)]
        public DescribeInstanceAuthInfoResponseBodyApiKeys ApiKeys { get; set; }
        public class DescribeInstanceAuthInfoResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <para>Supabase ANON_KEY</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyxxxJ9.ey****</para>
            /// </summary>
            [NameInMap("AnonKey")]
            [Validation(Required=false)]
            public string AnonKey { get; set; }

            /// <summary>
            /// <para>Supabase SERVICE_ROLE_KEY</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyxxxJ9.ey****KfQ.DaYxxxt4Q</para>
            /// </summary>
            [NameInMap("ServiceKey")]
            [Validation(Required=false)]
            public string ServiceKey { get; set; }

        }

        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeInstanceAuthInfoResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeInstanceAuthInfoResponseBodyConfigList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i5o1XAp4sR*****oyOb3O</para>
        /// </summary>
        [NameInMap("JwtSecret")]
        [Validation(Required=false)]
        public string JwtSecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>87249A6F-xxx-804C-E1E0AD1FAD90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
