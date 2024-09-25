// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcPublishedRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1D0971B2-A35A-42C1-A44C-E91360C36C0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<ListVpcPublishedRouteEntriesResponseBodyRouteEntries> RouteEntries { get; set; }
        public class ListVpcPublishedRouteEntriesResponseBodyRouteEntries : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rte-bp1mnnr2al0naomnpv****</para>
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            [NameInMap("RoutePublishTargets")]
            [Validation(Required=false)]
            public List<ListVpcPublishedRouteEntriesResponseBodyRouteEntriesRoutePublishTargets> RoutePublishTargets { get; set; }
            public class ListVpcPublishedRouteEntriesResponseBodyRouteEntriesRoutePublishTargets : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                [NameInMap("PublishTargetInstanceId")]
                [Validation(Required=false)]
                public string PublishTargetInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ECR</para>
                /// </summary>
                [NameInMap("PublishTargetType")]
                [Validation(Required=false)]
                public string PublishTargetType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vtb-2ze3jgygk9bmsj23s****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
