// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcPublishedRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> has a value, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D0971B2-A35A-42C1-A44C-E91360C36C0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of route entry publish status information.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<ListVpcPublishedRouteEntriesResponseBodyRouteEntries> RouteEntries { get; set; }
        public class ListVpcPublishedRouteEntriesResponseBodyRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rte-bp1mnnr2al0naomnpv****</para>
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            /// <summary>
            /// <para>The list of publish status information for the route entry in publish targets.</para>
            /// </summary>
            [NameInMap("RoutePublishTargets")]
            [Validation(Required=false)]
            public List<ListVpcPublishedRouteEntriesResponseBodyRouteEntriesRoutePublishTargets> RoutePublishTargets { get; set; }
            public class ListVpcPublishedRouteEntriesResponseBodyRouteEntriesRoutePublishTargets : TeaModel {
                /// <summary>
                /// <para>The publish status of the route entry in the publish target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// <para>The instance ID of the route publish target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecr-xvuqdfma6x57ei****</para>
                /// </summary>
                [NameInMap("PublishTargetInstanceId")]
                [Validation(Required=false)]
                public string PublishTargetInstanceId { get; set; }

                /// <summary>
                /// <para>The route publish target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECR</para>
                /// </summary>
                [NameInMap("PublishTargetType")]
                [Validation(Required=false)]
                public string PublishTargetType { get; set; }

            }

            /// <summary>
            /// <para>The route table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2ze3jgygk9bmsj23s****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
