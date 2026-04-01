// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public DescribeMountTargetsResponseBodyMountTargets MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            [NameInMap("MountTarget")]
            [Validation(Required=false)]
            public List<DescribeMountTargetsResponseBodyMountTargetsMountTarget> MountTarget { get; set; }
            public class DescribeMountTargetsResponseBodyMountTargetsMountTarget : TeaModel {
                [NameInMap("AccessGroup")]
                [Validation(Required=false)]
                public string AccessGroup { get; set; }

                [NameInMap("ClientMasterNodes")]
                [Validation(Required=false)]
                public DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes : TeaModel {
                    [NameInMap("ClientMasterNode")]
                    [Validation(Required=false)]
                    public List<DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                    public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                        [NameInMap("DefaultPasswd")]
                        [Validation(Required=false)]
                        public string DefaultPasswd { get; set; }

                        [NameInMap("EcsId")]
                        [Validation(Required=false)]
                        public string EcsId { get; set; }

                        [NameInMap("EcsIp")]
                        [Validation(Required=false)]
                        public string EcsIp { get; set; }

                    }

                }

                [NameInMap("DualStackMountTargetDomain")]
                [Validation(Required=false)]
                public string DualStackMountTargetDomain { get; set; }

                [NameInMap("IPVersion")]
                [Validation(Required=false)]
                public string IPVersion { get; set; }

                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMountTargetsResponseBodyMountTargetsMountTargetTags Tags { get; set; }
                public class DescribeMountTargetsResponseBodyMountTargetsMountTargetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMountTargetsResponseBodyMountTargetsMountTargetTagsTag> Tag { get; set; }
                    public class DescribeMountTargetsResponseBodyMountTargetsMountTargetTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
