// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetExampleQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the sample query template.</para>
        /// </summary>
        [NameInMap("ExampleQuery")]
        [Validation(Required=false)]
        public GetExampleQueryResponseBodyExampleQuery ExampleQuery { get; set; }
        public class GetExampleQueryResponseBodyExampleQuery : TeaModel {
            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Queries all resources on which you have permissions and sorts the resources by resource type and resource ID.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The query statement in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT
            ///   resource_id,
            ///   resource_name,
            ///   region_id,
            ///   zone_id,
            ///   resource_type,
            ///   account_id,
            ///   create_time,
            ///   resource_group_id,
            ///   tags,
            ///   ip_addresses,
            ///   vpc_id,
            ///   v_switch_id
            /// FROM
            ///   resources
            /// ORDER BY
            ///   resource_type,
            ///   resource_id
            /// LIMIT
            ///   1000 OFFSET 0;</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query of All Alibaba Cloud Resources</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sq-0PfKy****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36A3D9BE-B607-5993-B546-7E19EF65DC00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
