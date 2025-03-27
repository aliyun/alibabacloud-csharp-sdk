// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceBootConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Schema of Response</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstanceBootConfigurationResponseBodyInstances Instances { get; set; }
        public class DescribeInstanceBootConfigurationResponseBodyInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>legacy</para>
            /// </summary>
            [NameInMap("BootSet")]
            [Validation(Required=false)]
            public string BootSet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("BootType")]
            [Validation(Required=false)]
            public string BootType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("DiskSet")]
            [Validation(Required=false)]
            public string DiskSet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
