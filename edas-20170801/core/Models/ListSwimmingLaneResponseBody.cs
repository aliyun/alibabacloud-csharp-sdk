// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSwimmingLaneResponseBodyData> Data { get; set; }
        public class ListSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the throttling rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            /// <summary>
            /// <para>The conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;condition\&quot;:\&quot;AND\&quot;,\&quot;enable\&quot;:true,\&quot;path\&quot;:\&quot;/\&quot;,\&quot;priority\&quot;:1,\&quot;restItems\&quot;:[{\&quot;cond\&quot;:\&quot;==\&quot;,\&quot;datum\&quot;:\&quot;value\&quot;,\&quot;name\&quot;:\&quot;tags\&quot;,\&quot;operator\&quot;:\&quot;rawvalue\&quot;,\&quot;type\&quot;:\&quot;header\&quot;,\&quot;value\&quot;:\&quot;value\&quot;}]}]</para>
            /// </summary>
            [NameInMap("EntryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The ID of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>348</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the microservices namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou:pre2</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The expected tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d0ad1052</para>
            /// </summary>
            [NameInMap("ScenarioSign")]
            [Validation(Required=false)]
            public string ScenarioSign { get; set; }

            /// <summary>
            /// <para>The applications that are related to the lane.</para>
            /// </summary>
            [NameInMap("SwimmingLaneAppRelationShipList")]
            [Validation(Required=false)]
            public List<ListSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList> SwimmingLaneAppRelationShipList { get; set; }
            public class ListSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3b615783-01f1-4569-baa3-cb71bdb6****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod-app-58846</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>Additional information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas-canary</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public string Extra { get; set; }

                /// <summary>
                /// <para>The ID of the lane.</para>
                /// 
                /// <b>Example:</b>
                /// <para>348</para>
                /// </summary>
                [NameInMap("LaneId")]
                [Validation(Required=false)]
                public long? LaneId { get; set; }

                /// <summary>
                /// <para>The association rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

            }

            /// <summary>
            /// <para>The tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2cb6b8a</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2CDBBF9-9C9A-5AA1-9F39-094ADEB3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
