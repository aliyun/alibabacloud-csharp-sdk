// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2956025-4E5C-529D-92B4-B2591DDED067</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The information about the provenance graph.</para>
        /// </summary>
        [NameInMap("TracingDetail")]
        [Validation(Required=false)]
        public QueryIncidentTracingDetailResponseBodyTracingDetail TracingDetail { get; set; }
        public class QueryIncidentTracingDetailResponseBodyTracingDetail : TeaModel {
            /// <summary>
            /// <para>The edges.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailEdgeList> EdgeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailEdgeList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the current edge belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1277498600854739</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// <para>The ID of the end node for the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>223a185f05e5fc3c637</para>
                /// </summary>
                [NameInMap("EndId")]
                [Validation(Required=false)]
                public string EndId { get; set; }

                /// <summary>
                /// <para>The type of the end node for the current edge. Valid values include the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>process_test_process</para>
                /// </summary>
                [NameInMap("EndType")]
                [Validation(Required=false)]
                public string EndType { get; set; }

                /// <summary>
                /// <para>The name of the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mongod</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The origin vertex ID of the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>distribution</para>
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                /// <summary>
                /// <para>The text that contains the properties of the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;bandWidth\&quot;:\&quot;8192\&quot;,\&quot;internetIp\&quot;:\&quot;8.211.13.50\&quot;,\&quot;changeReason\&quot;:\&quot;EIP_BIND\&quot;,\&quot;bindInstanceId\&quot;:\&quot;i-gw887xhzjvyjfv7vdfs3\&quot;,\&quot;bindType\&quot;:\&quot;EIP_ECS\&quot;}</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>The property of the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;coverage\&quot;:\&quot;global\&quot;}</para>
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// <para>The ID of the rule based on which the current edge is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>136</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The display type of the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// <para>The ID of the start node for the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23003</para>
                /// </summary>
                [NameInMap("StartId")]
                [Validation(Required=false)]
                public string StartId { get; set; }

                /// <summary>
                /// <para>The type of the start node for the current edge. Valid values include the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b>:</description></item>
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
                /// <para>The time when the current edge was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1652941117</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the current edge was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1636092632</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The type of the current edge. Valid values include the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>process_exec_file</b>: The relationship indicates an executable file that is run by a process.</description></item>
                /// <item><description><b>process_connect_ip</b>: The relationship indicates an IP address that is connected by a process.</description></item>
                /// <item><description><b>domain_trgger_alert</b>: The relationship indicates an alert that is triggered for a domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>elf</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The type of the current edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cis</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

                /// <summary>
                /// <para>The time when the current edge was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-13 12:49:33</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The UUID of the current edge. The SIEM system generates UUIDs for nodes and edges in the provenance graph to help you locate the nodes or edges.</para>
                /// 
                /// <b>Example:</b>
                /// <para>678e29f4-d78f-4a7c-a2bc-38434a138538</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The entities.</para>
            /// </summary>
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailEntityTypeList : TeaModel {
                /// <summary>
                /// <para>The version ID of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1768</para>
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// <para>The display color of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFF</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The display icon of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The display sequence of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// <para>The display template of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The time when the current entity was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-09T10:53Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the current entity was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1585816811000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1425</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is a virtual node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public int? IsVirtualNode { get; set; }

                /// <summary>
                /// <para>The type of the current entity. Valid values include the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto-test-policy-name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The synchronization ID of the current entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e2fdf402-b4ed-4e1a-9e95-44d6069600b0</para>
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

                /// <summary>
                /// <para>The tag that indicates whether tracing was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: successful</description></item>
                /// <item><description><b>0</b>: failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public int? TraceSuccessFlag { get; set; }

            }

            /// <summary>
            /// <para>The rendering language of the returned result. Valid values:</para>
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
            /// <para>The relationships.</para>
            /// </summary>
            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailRelationTypeList : TeaModel {
                /// <summary>
                /// <para>The version ID of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1487</para>
                /// </summary>
                [NameInMap("CurrentVersionId")]
                [Validation(Required=false)]
                public string CurrentVersionId { get; set; }

                /// <summary>
                /// <para>The direction of the current relationship. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: forward</description></item>
                /// <item><description><b>0</b>: reverse</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public int? Directed { get; set; }

                /// <summary>
                /// <para>The display color of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FFF</para>
                /// </summary>
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                /// <summary>
                /// <para>The display icon of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i2/O1CN01jpZwD31G56XYPEJv2_!!600000000****-55-tps-25-28.svg">https://img.alicdn.com/imgextra/i2/O1CN01jpZwD31G56XYPEJv2_!!600000000****-55-tps-25-28.svg</a></para>
                /// </summary>
                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                /// <summary>
                /// <para>The display template of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                /// <summary>
                /// <para>The time when the current relationship was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-23T10:50Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the current relationship was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-12T07:58:49Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1514</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the current relationship. Valid values include the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>process_exec_file</b>: The relationship indicates an executable file that is run by a process.</description></item>
                /// <item><description><b>process_connect_ip</b>: The relationship indicates an IP address that is connected by a process.</description></item>
                /// <item><description><b>domain_trgger_alert</b>: The relationship indicates an alert that is triggered for a domain name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>wusa</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The display type of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

                /// <summary>
                /// <para>The synchronization ID of the current relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sync-0000aws50gyy2ocisbmx</para>
                /// </summary>
                [NameInMap("SyncId")]
                [Validation(Required=false)]
                public int? SyncId { get; set; }

            }

            /// <summary>
            /// <para>The nodes.</para>
            /// </summary>
            [NameInMap("VertexList")]
            [Validation(Required=false)]
            public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexList> VertexList { get; set; }
            public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the current node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1487146717137516</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// <para>The display information of the current node.</para>
                /// </summary>
                [NameInMap("DisplayInfo")]
                [Validation(Required=false)]
                public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexListDisplayInfo> DisplayInfo { get; set; }
                public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexListDisplayInfo : TeaModel {
                    /// <summary>
                    /// <para>The name of the property that needs to be displayed for the current node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>scan:ACSV-2020-111301</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the property that needs to be displayed for the current node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.16.1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the current node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>383044</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The rendering language of the current node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// <para>The name of the current node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto-test-attestor</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The nodes that are adjacent to the current node.</para>
                /// </summary>
                [NameInMap("NeighborList")]
                [Validation(Required=false)]
                public List<QueryIncidentTracingDetailResponseBodyTracingDetailVertexListNeighborList> NeighborList { get; set; }
                public class QueryIncidentTracingDetailResponseBodyTracingDetailVertexListNeighborList : TeaModel {
                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>Indicates whether more nodes are adjacent to the current node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("HasMore")]
                    [Validation(Required=false)]
                    public bool? HasMore { get; set; }

                    /// <summary>
                    /// <para>The type of the node. Valid values include the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>process</b></description></item>
                    /// <item><description><b>file</b></description></item>
                    /// <item><description><b>alert</b></description></item>
                    /// <item><description><b>ip</b></description></item>
                    /// <item><description><b>domain</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The text that contains the properties of the current node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;PropertyValues\&quot;: [{\&quot;PropertyValueId\&quot;: 239, \&quot;PropertyValue\&quot;: \&quot;121\&quot;}, {\&quot;PropertyValueId\&quot;: 240, \&quot;PropertyValue\&quot;: \&quot;6666\&quot;}], \&quot;PropertyKey\&quot;: \&quot;22222222\&quot;, \&quot;PropertyId\&quot;: 203}]</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public string Properties { get; set; }

                /// <summary>
                /// <para>The property of the current node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;coverage\&quot;:\&quot;global\&quot;}</para>
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public Dictionary<string, object> Property { get; set; }

                /// <summary>
                /// <para>The ID of the rule based on which the current node is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>301425</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The time when the current node was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-26</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the current node was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1663048980</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The type of the current node. Valid values include the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>process</b></description></item>
                /// <item><description><b>file</b></description></item>
                /// <item><description><b>alert</b></description></item>
                /// <item><description><b>ip</b></description></item>
                /// <item><description><b>domain</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alidetect</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the current node was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-13 12:49:33</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The UUID of the current node. The security information and event management (SIEM) system generates UUIDs for nodes and edges in the provenance graph to help you locate the nodes or edges.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32e36d8a-2b5d-4f71-98a8-12775685a3b4</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

    }

}
