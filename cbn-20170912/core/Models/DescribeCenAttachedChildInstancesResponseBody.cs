// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenAttachedChildInstancesResponseBody : TeaModel {
        [NameInMap("ChildInstances")]
        [Validation(Required=false)]
        public DescribeCenAttachedChildInstancesResponseBodyChildInstances ChildInstances { get; set; }
        public class DescribeCenAttachedChildInstancesResponseBodyChildInstances : TeaModel {
            [NameInMap("ChildInstance")]
            [Validation(Required=false)]
            public List<DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance> ChildInstance { get; set; }
            public class DescribeCenAttachedChildInstancesResponseBodyChildInstancesChildInstance : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("ChildInstanceAttachTime")]
                [Validation(Required=false)]
                public string ChildInstanceAttachTime { get; set; }

                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                [NameInMap("ManagedService")]
                [Validation(Required=false)]
                public string ManagedService { get; set; }

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
