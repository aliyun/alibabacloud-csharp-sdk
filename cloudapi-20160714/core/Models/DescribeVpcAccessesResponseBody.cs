// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeVpcAccessesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8883AC74-259D-4C0B-99FC-0B7F9A588B2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpcAccessAttributes")]
        [Validation(Required=false)]
        public DescribeVpcAccessesResponseBodyVpcAccessAttributes VpcAccessAttributes { get; set; }
        public class DescribeVpcAccessesResponseBodyVpcAccessAttributes : TeaModel {
            [NameInMap("VpcAccessAttribute")]
            [Validation(Required=false)]
            public List<DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttribute> VpcAccessAttribute { get; set; }
            public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttribute : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTags Tags { get; set; }
                public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeVpcAccessesResponseBodyVpcAccessAttributesVpcAccessAttributeTagsTagInfo : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VpcAccessId")]
                [Validation(Required=false)]
                public string VpcAccessId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcTargetHostName")]
                [Validation(Required=false)]
                public string VpcTargetHostName { get; set; }

            }

        }

    }

}
