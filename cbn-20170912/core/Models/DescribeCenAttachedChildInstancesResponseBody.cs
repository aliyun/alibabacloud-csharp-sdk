// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the network instances.</para>
        /// </summary>
        [NameInMap("ChildInstances")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstancesResponseBodyChildInstances ChildInstances { get; set; }
        public class DescribeCenAttachedChildInstancesResponseBodyChildInstances : TeaModel {
            [NameInMap("ChildInstance")]
            [Validation(Required=false)]
            public List<DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance> ChildInstance { get; set; }
            public class DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance : TeaModel {
                /// <summary>
                /// <para>The ID of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-j3jzhw1zpau2km****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The time when the network instance was attached to the CEN instance.</para>
                /// <para>The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-10T06:27Z</para>
                /// </summary>
                [NameInMap("ChildInstanceAttachTime")]
                [Validation(Required=false)]
                public string ChildInstanceAttachTime { get; set; }

                /// <summary>
                /// <para>The ID of the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vb1lu55yt9rlwgxl****</para>
                /// </summary>
                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the network instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1688000000000000</para>
                /// </summary>
                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                /// <summary>
                /// <para>The ID of the region where the network instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                /// <summary>
                /// <para>The type of the network instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: VPC</description></item>
                /// <item><description><b>VBR</b>: VBR</description></item>
                /// <item><description><b>CCN</b>: CCN instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                /// <summary>
                /// <para>The status of the network instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Attaching</b>: The network instance is being created on the transit router.</description></item>
                /// <item><description><b>Attached</b>: The network instance has been created on the transit router.</description></item>
                /// <item><description><b>Detaching</b>: The network instance is being deleted from the transit router.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Attached</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
        /// <para>The number of entries returned per page.</para>
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
        /// <para>B2063B16-852B-5B66-B73D-4ED4D1A5E5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
