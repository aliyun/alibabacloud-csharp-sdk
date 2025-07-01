// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried mount targets.</para>
        /// </summary>
        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public DescribeMountTargetsResponseBodyMountTargets MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            [NameInMap("MountTarget")]
            [Validation(Required=false)]
            public List<DescribeMountTargetsResponseBodyMountTargetsMountTarget> MountTarget { get; set; }
            public class DescribeMountTargetsResponseBodyMountTargetsMountTarget : TeaModel {
                /// <summary>
                /// <para>The name of the permission group that is attached to the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_VPC_GROUP_NAME</para>
                /// </summary>
                [NameInMap("AccessGroup")]
                [Validation(Required=false)]
                public string AccessGroup { get; set; }

                /// <summary>
                /// <para>The information about client management nodes.</para>
                /// </summary>
                [NameInMap("ClientMasterNodes")]
                [Validation(Required=false)]
                public DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes : TeaModel {
                    [NameInMap("ClientMasterNode")]
                    [Validation(Required=false)]
                    public List<DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                    public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                        /// <summary>
                        /// <para>The default logon password of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12****</para>
                        /// </summary>
                        [NameInMap("DefaultPasswd")]
                        [Validation(Required=false)]
                        public string DefaultPasswd { get; set; }

                        /// <summary>
                        /// <para>The ID of the ECS instance on the client management node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-hp3i3odi5ory1buo****</para>
                        /// </summary>
                        [NameInMap("EcsId")]
                        [Validation(Required=false)]
                        public string EcsId { get; set; }

                        /// <summary>
                        /// <para>The IP address of the ECS instance on the client management node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.0</para>
                        /// </summary>
                        [NameInMap("EcsIp")]
                        [Validation(Required=false)]
                        public string EcsIp { get; set; }

                    }

                }

                /// <summary>
                /// <para>The dual-stack (IPv4 and IPv6) domain name of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1ca404****-x****.dualstack.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("DualStackMountTargetDomain")]
                [Validation(Required=false)]
                public string DualStackMountTargetDomain { get; set; }

                /// <summary>
                /// <para>The type of the mount target.</para>
                /// <list type="bullet">
                /// <item><description>IPv4: an IPv4 mount target</description></item>
                /// <item><description>DualStack: a dual-stack mount target</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IPVersion")]
                [Validation(Required=false)]
                public string IPVersion { get; set; }

                /// <summary>
                /// <para>The IPv4 domain name of the mount target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1ca404****-w****.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                /// <summary>
                /// <para>The network type. Valid value: <b>Vpc</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The status of the mount target.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Active: The mount target is available.</description></item>
                /// <item><description>Inactive: The mount target is unavailable.</description></item>
                /// <item><description>Pending: The mount target is being created or modified.</description></item>
                /// <item><description>Deleting: The mount target is being deleted.</description></item>
                /// <item><description>Hibernating: The mount target is being hibernated.</description></item>
                /// <item><description>Hibernated: The mount target is hibernated.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You can mount a file system only when the mount target of the file system is in the Active state.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>An array of tags. The array may contain up to 20 tags. If the array contains multiple tags, each tag key is unique.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMountTargetsResponseBodyMountTargetsMountTargetTags Tags { get; set; }
                public class DescribeMountTargetsResponseBodyMountTargetsMountTargetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMountTargetsResponseBodyMountTargetsMountTargetTagsTag> Tag { get; set; }
                    public class DescribeMountTargetsResponseBodyMountTargetsMountTargetTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key. Limits:</para>
                        /// <list type="bullet">
                        /// <item><description>The tag key cannot be null or an empty string.</description></item>
                        /// <item><description>The tag key can be up to 128 characters in length.</description></item>
                        /// <item><description>The key value cannot start with aliyun or acs:.</description></item>
                        /// <item><description>The key value cannot contain http:// or https://.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>nastest</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// <para>Limits:</para>
                        /// <list type="bullet">
                        /// <item><description>The tag value can be up to 128 characters in length.</description></item>
                        /// <item><description>The tag value cannot contain http:// or https://.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mounttargettest</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zesj9afh3y518k9o****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-2zevmwkwyztjuoffg****</para>
                /// </summary>
                [NameInMap("VswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BAB90FD-B4A0-48DA-9F09-2B963510****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of mount targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
