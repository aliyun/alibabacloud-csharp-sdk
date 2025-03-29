// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20191209.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1578067200000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbaudit-cn-78v1gc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tsiqvqjjlq-public.dbaudit.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tsiqvqjjlq.dbaudit.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alpha.professional</para>
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alpha</para>
            /// </summary>
            [NameInMap("SeriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1577437765000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5b****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp1kep1f0k5fnyfs****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28382024-466D-4641-A144-40FD0DD53766</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
