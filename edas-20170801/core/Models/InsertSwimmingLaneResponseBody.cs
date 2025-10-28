// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneResponseBody : TeaModel {
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
        public InsertSwimmingLaneResponseBodyData Data { get; set; }
        public class InsertSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The applications that are associated with lanes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;appId&quot;:&quot;9dcba109-ee9f-4e67-8916-41
            /// *******&quot;}]</para>
            /// </summary>
            [NameInMap("AppInfos")]
            [Validation(Required=false)]
            public string AppInfos { get; set; }

            /// <summary>
            /// <para>The throttling rule for the lane.</para>
            /// <para>priority: the priority of the throttling rule for the lane. Valid values: 1 to 100.</para>
            /// <para>path: the path that is matched by the throttling rule for the lane.</para>
            /// <para>restItems: conditions to be met.</para>
            /// <para>condition: the relationship among the conditions to be met.</para>
            /// <list type="bullet">
            /// <item><description>AND: all conditions</description></item>
            /// <item><description>OR: one of the conditions</description></item>
            /// </list>
            /// <para>restItems.type: the type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>header: matches by request header.</description></item>
            /// <item><description>cookie: matches by request cookie.</description></item>
            /// <item><description>param: matches by request parameters.</description></item>
            /// </list>
            /// <para>restItems.name: the key that matches the rule.</para>
            /// <para>restItems.value: the value that matches the rule.</para>
            /// <para>restItems.cond: the condition that matches the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>&quot;==&quot;: The parameter value is equal to the value that you enter in the Value field.</description></item>
            /// <item><description>&quot;!=&quot;: The parameter value is not equal to the value that you enter in the Value field.</description></item>
            /// <item><description>&quot;&gt;&quot;: The parameter value is greater than the value that you enter in the Value field.</description></item>
            /// <item><description>&quot;&lt;&quot;: The parameter value is less than the value that you enter in the Value field.</description></item>
            /// <item><description>&quot;&gt;=&quot;: The parameter value is greater than or equal to the value that you enter in the Value field.</description></item>
            /// <item><description>&quot;&lt;=&quot;: The parameter value is less than or equal to the value that you enter in the Value field.</description></item>
            /// <item><description>&quot;in&quot;: The parameter value is within the values that you enter in the Value field.</description></item>
            /// </list>
            /// <para>restItems.operator: the type of the value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>rawvalue: the initial value</description></item>
            /// <item><description>mod: the reminder obtained by performing modulo operation</description></item>
            /// <item><description>list: the value from the list</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;condition\&quot;:\&quot;AND\&quot;,\&quot;enable\&quot;:false,\&quot;path\&quot;:\&quot;/traffic\&quot;,\&quot;priority\&quot;:1,\&quot;restItems\&quot;:[{\&quot;cond\&quot;:\&quot;==\&quot;,\&quot;datum\&quot;:\&quot;testvalue\&quot;,\&quot;name\&quot;:\&quot;testheader\&quot;,\&quot;operator\&quot;:\&quot;rawvalue\&quot;,\&quot;type\&quot;:\&quot;header\&quot;,\&quot;value\&quot;:\&quot;testvalue\&quot;}]}]</para>
            /// </summary>
            [NameInMap("EntryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The ID of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The association relationships between lanes and applications.</para>
            /// </summary>
            [NameInMap("SwimmingLaneAppRelationShipList")]
            [Validation(Required=false)]
            public List<InsertSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList> SwimmingLaneAppRelationShipList { get; set; }
            public class InsertSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bd170895-096c-4944-9007-d4582c77****</para>
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
                /// <para>88</para>
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
            /// <para>8202e09</para>
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
        /// <para>75972A87-5682-5277-ADA7-DA2A01BE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
