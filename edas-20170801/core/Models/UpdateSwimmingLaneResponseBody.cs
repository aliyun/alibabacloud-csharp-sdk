// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSwimmingLaneResponseBody : TeaModel {
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
        public UpdateSwimmingLaneResponseBodyData Data { get; set; }
        public class UpdateSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The rule of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;condition\&quot;:\&quot;AND\&quot;,\&quot;enable\&quot;:true,\&quot;path\&quot;:\&quot;/traffictest\&quot;,\&quot;priority\&quot;:1,\&quot;restItems\&quot;:[{\&quot;cond\&quot;:\&quot;==\&quot;,\&quot;datum\&quot;:\&quot;testheadervalue\&quot;,\&quot;name\&quot;:\&quot;testheader\&quot;,\&quot;operator\&quot;:\&quot;rawvalue\&quot;,\&quot;type\&quot;:\&quot;header\&quot;,\&quot;value\&quot;:\&quot;testheadervalue\&quot;}]}]&quot;</para>
            /// </summary>
            [NameInMap("EntryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The ID of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>321</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-swimlane</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:qa</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The list of associations between the lane and the related application.</para>
            /// </summary>
            [NameInMap("SwimmingLaneAppRelationShipList")]
            [Validation(Required=false)]
            public List<UpdateSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList> SwimmingLaneAppRelationShipList { get; set; }
            public class UpdateSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>476d26d9-b54c-40b8-8af9-d898cdc2****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The ID of the lane.</para>
                /// 
                /// <b>Example:</b>
                /// <para>321</para>
                /// </summary>
                [NameInMap("LaneId")]
                [Validation(Required=false)]
                public long? LaneId { get; set; }

                /// <summary>
                /// <para>The association rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dubbo</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

            }

            /// <summary>
            /// <para>The tag of the lane.</para>
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
        /// <para>6CB46AEA-309C-5041-9EC7-FCF4478F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
