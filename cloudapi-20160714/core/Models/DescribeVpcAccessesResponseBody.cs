// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeVpcAccessesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the VPC access authorization. The information is an array consisting of VpcAccessAttribute data.
        /// </summary>
        [NameInMap("VpcAccessAttributes")]
        [Validation(Required=false)]
        public DescribeVpcAccessesResponseBodyVpcAccessAttributes VpcAccessAttributes { get; set; }
        public class DescribeVpcAccessesResponseBodyVpcAccessAttributes : TeaModel {
            [NameInMap("VpcAccessAttribute")]
            [Validation(Required=false)]
            public List<DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttribute> VpcAccessAttribute { get; set; }
            public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttribute : TeaModel {
                /// <summary>
                /// The time when the authorization was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The description of the VPC access authorization.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the Elastic Compute Service (ECS) or Server Load Balancer (SLB) instance in the VPC.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the authorization.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The port number that corresponds to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The list of tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTags Tags { get; set; }
                public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTagsTagInfo : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the VPC access authorization.
                /// </summary>
                [NameInMap("VpcAccessId")]
                [Validation(Required=false)]
                public string VpcAccessId { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The host of the backend service.
                /// </summary>
                [NameInMap("VpcTargetHostName")]
                [Validation(Required=false)]
                public string VpcTargetHostName { get; set; }

            }

        }

    }

}
