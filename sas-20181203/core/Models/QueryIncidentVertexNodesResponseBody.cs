// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BREF20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The results that are returned.</para>
        /// </summary>
        [NameInMap("VertexNodes")]
        [Validation(Required=false)]
        public QueryIncidentVertexNodesResponseBodyVertexNodes VertexNodes { get; set; }
        public class QueryIncidentVertexNodesResponseBodyVertexNodes : TeaModel {
            /// <summary>
            /// <para>The edges that are returned.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesEdgeList> EdgeList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesEdgeList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the edge belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20973951</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// <para>The ID of the end node for the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64002</para>
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// <para>The type of the end node for the edge. Valid values include but are not limited to:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("EndType")]
                [Validation(Required=false)]
                public string EndType { get; set; }

                /// <summary>
                /// <para>The name of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jdk</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The original name of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>distribution</para>
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                /// <summary>
                /// <para>The properties of the edge. The value is in the text format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;bandWidth\&quot;:\&quot;7810048\&quot;,\&quot;internetIp\&quot;:\&quot;47.57.13.255\&quot;,\&quot;changeReason\&quot;:\&quot;MODIFY_SPEC\&quot;,\&quot;bindInstanceId\&quot;:\&quot;i-j6chvo01tle7qfnhewr3\&quot;,\&quot;bindType\&quot;:\&quot;EIP_ECS\&quot;}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>The property of the edge.</para>
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// <para>The ID of the rule based on which the edge was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>368</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The display type of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// <para>The ID of the start node for the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>52003</para>
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// <para>The type of the start node for the edge. Valid values include but are not limited to:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>process</para>
                /// </summary>
                [NameInMap("StartType")]
                [Validation(Required=false)]
                public string StartType { get; set; }

                /// <summary>
                /// <para>The time when the edge was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-06 11:00:00</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The time when the edge was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1645168444</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The type of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cve</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The type name of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weak_password</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

                /// <summary>
                /// <para>The time when the edge was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-16T07:20:33.000Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The UUID of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>549237d6-86d1-47f6-9ffa-3f97da9e6b10</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The entities that are returned.</para>
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesEntityTypeList : TeaModel {
                /// <summary>
                /// <para>The version of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>993</para>
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// <para>The display color of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The display icon of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.22222.com">http://img.22222.com</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The display order of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// <para>The display template of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>template1</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The time when the entity was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-23T10:50Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the entity was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1623317089000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33926</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is a virtual node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public int? IsVirtualNode { get; set; }

                /// <summary>
                /// <para>The name of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto-test-policy-name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The synchronization ID of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3212024a-1816-46d5-b286-e5d5780fd778</para>
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is traced. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The entity is traced.</description></item>
                /// <item><description><b>0</b>: The entity fails to be traced.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public int? TraceSuccessFlag { get; set; }

            }

            /// <summary>
            /// <para>The language of the content within the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh</b>: Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The relationships that are returned.</para>
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesRelationTypeList : TeaModel {
                /// <summary>
                /// <para>The version of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1487</para>
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// <para>The display icon of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.33.com">http://img.33.com</a></para>
                /// </summary>
                [NameInMap("DIsplayIcon")]
                [Validation(Required=false)]
                public string DIsplayIcon { get; set; }

                /// <summary>
                /// <para>The direction of the relationship. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: forward.</description></item>
                /// <item><description><b>0</b>: reverse.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>in</para>
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                /// <summary>
                /// <para>The display color of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The display template of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>template1</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The time when the relationship was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-02T10:20Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the relationship was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1637556498000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9350</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mongod</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The display type of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type1</para>
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// <para>The synchronization ID of the relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a45185c7-b1b8-4a49-b04a-d6bfa051ef0e</para>
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

            }

            /// <summary>
            /// <para>The information about the node.</para>
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexNodesResponseBodyVertexNodesVertexList> VertexList { get; set; }
            public class QueryIncidentVertexNodesResponseBodyVertexNodesVertexList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20973951</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// <para>The display information of the node.</para>
                /// </summary>
                [NameInMap("DisplayInfo")]
                [Validation(Required=false)]
                public List<QueryIncidentVertexNodesResponseBodyVertexNodesVertexListDisplayInfo> DisplayInfo { get; set; }
                public class QueryIncidentVertexNodesResponseBodyVertexNodesVertexListDisplayInfo : TeaModel {
                    /// <summary>
                    /// <para>The display name of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zabbix</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The display value of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-nacos</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>225</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The display language of the neighboring node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>zh</b>: Chinese.</description></item>
                /// <item><description><b>en</b>: English.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zabbix</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The neighboring nodes of the node.</para>
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<QueryIncidentVertexNodesResponseBodyVertexNodesVertexListNeighborList> NeighborList { get; set; }
                public class QueryIncidentVertexNodesResponseBodyVertexNodesVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// <para>The number of neighboring nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>27</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>Indicates whether more neighboring nodes exist. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// <para>The type of the neighboring node. Valid values include but are not limited to:</para>
                    /// <list type="bullet">
                    /// <item><description><b>process</b></description></item>
                    /// <item><description><b>file</b></description></item>
                    /// <item><description><b>alert</b></description></item>
                    /// <item><description><b>ip</b></description></item>
                    /// <item><description><b>domain</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>elf</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The properties of the node. The value is in the text format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;bandWidth\&quot;:\&quot;5120\&quot;,\&quot;internetIp\&quot;:\&quot;47.242.191.206\&quot;,\&quot;changeReason\&quot;:\&quot;EIP_BIND\&quot;,\&quot;bindInstanceId\&quot;:\&quot;eci-j6ci7lvci50rore7dkv8\&quot;,\&quot;bindType\&quot;:\&quot;EIP_ECS\&quot;}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>The property of the node.</para>
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// <para>The ID of the rule based on which the node was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>171</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The time when the node was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1636081135</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The time when the node was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1645179073</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values include but are not limited to:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sys</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the node was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-16T07:20:33.000Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The UUID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02ca8614-ecdb-44d3-b3d0-158655080e4f</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

    }

}
