// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastEipAddressResponseBody : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("AnycastEipBindInfoList")]
        [Validation(Required=false)]
        public List<DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoList> AnycastEipBindInfoList { get; set; }
        public class DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoList : TeaModel {
            /// <summary>
            /// 绑定模式 Normal、Default
            /// </summary>
            [NameInMap("AssociationMode")]
            [Validation(Required=false)]
            public string AssociationMode { get; set; }

            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            [NameInMap("BindInstanceRegionId")]
            [Validation(Required=false)]
            public string BindInstanceRegionId { get; set; }

            [NameInMap("BindInstanceType")]
            [Validation(Required=false)]
            public string BindInstanceType { get; set; }

            [NameInMap("BindTime")]
            [Validation(Required=false)]
            public string BindTime { get; set; }

            /// <summary>
            /// 关联的pop点
            /// </summary>
            [NameInMap("PopLocations")]
            [Validation(Required=false)]
            public List<DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoListPopLocations> PopLocations { get; set; }
            public class DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoListPopLocations : TeaModel {
                /// <summary>
                /// PopLocation
                /// </summary>
                [NameInMap("PopLocation")]
                [Validation(Required=false)]
                public string PopLocation { get; set; }

            }

            /// <summary>
            /// ip地址
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
