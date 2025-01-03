// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAndroidInstancesResponseBody : TeaModel {
        [NameInMap("InstanceModel")]
        [Validation(Required=false)]
        public List<DescribeAndroidInstancesResponseBodyInstanceModel> InstanceModel { get; set; }
        public class DescribeAndroidInstancesResponseBodyInstanceModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ag-ayyhomlal7po****</para>
            /// </summary>
            [NameInMap("AndroidInstanceGroupId")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupId { get; set; }

            [NameInMap("AndroidInstanceGroupName")]
            [Validation(Required=false)]
            public string AndroidInstanceGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-8at8h6ejkadjh****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("AndroidInstanceName")]
            [Validation(Required=false)]
            public string AndroidInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AndroidInstanceStatus")]
            [Validation(Required=false)]
            public string AndroidInstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aig-i7yv6tkn7kh8dv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ai-9ey6io0q58rcd****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public string AuthorizedUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("BindUserId")]
            [Validation(Required=false)]
            public string BindUserId { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstancesResponseBodyInstanceModelDisks> Disks { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelDisks : TeaModel {
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FilePathNotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-06 10:42:10</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-06 10:42:10</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kp-5hh431emkpucs****</para>
            /// </summary>
            [NameInMap("KeyPairId")]
            [Validation(Required=false)]
            public string KeyPairId { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.22.48</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-0btrd5zj8epo****</para>
            /// </summary>
            [NameInMap("PersistentAppInstanceId")]
            [Validation(Required=false)]
            public string PersistentAppInstanceId { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RenderingType")]
            [Validation(Required=false)]
            public string RenderingType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeAndroidInstancesResponseBodyInstanceModelTags> Tags { get; set; }
            public class DescribeAndroidInstancesResponseBodyInstanceModelTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kmma/xxE9WtwL/ADvZ****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F07A1DA1-E1EB-5CCA-8EED-12F85D32****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
