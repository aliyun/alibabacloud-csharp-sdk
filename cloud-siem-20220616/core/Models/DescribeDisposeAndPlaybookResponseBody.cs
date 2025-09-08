// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDisposeAndPlaybookResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDisposeAndPlaybookResponseBodyData Data { get; set; }
        public class DescribeDisposeAndPlaybookResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeDisposeAndPlaybookResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeDisposeAndPlaybookResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeDisposeAndPlaybookResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeDisposeAndPlaybookResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The number of alerts that are associated with the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                /// <summary>
                /// <para>The object for handling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("Dispose")]
                [Validation(Required=false)]
                public string Dispose { get; set; }

                /// <summary>
                /// <para>The entity ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The entity information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;file_path&quot;: &quot;c:/www/leixi.jsp&quot;,&quot;file_hash&quot;: &quot;aa0ca926ad948cd820e0a3d9a18c09d0&quot;,&quot;host_uuid&quot;: &quot;efed2cf7-0b77-45d9-a97b-d2cf246bcbb3&quot;,&quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.webshell}&quot;,&quot;host_name&quot;: &quot;launch-advisor-20230531&quot;}</para>
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EntityInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The key-value pairs each of which consists of opcode and oplevel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("OpcodeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> OpcodeMap { get; set; }

                /// <summary>
                /// <para>The codes of the playbooks that are recommended for entity handling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[1,3]</para>
                /// </summary>
                [NameInMap("OpcodeSet")]
                [Validation(Required=false)]
                public List<string> OpcodeSet { get; set; }

                /// <summary>
                /// <para>The playbooks that can handle the entity.</para>
                /// </summary>
                [NameInMap("PlaybookList")]
                [Validation(Required=false)]
                public List<DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList> PlaybookList { get; set; }
                public class DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList : TeaModel {
                    [NameInMap("Available")]
                    [Validation(Required=false)]
                    public string Available { get; set; }

                    /// <summary>
                    /// <para>The playbook description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WafBlockIP</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the playbook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WafBlockIP</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The playbook name, which is the unique identifier of the playbook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kill_process_isolate_file</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The opcode of the playbook, which corresponds to the opcode of the playbook recommended for entity handling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("OpCode")]
                    [Validation(Required=false)]
                    public string OpCode { get; set; }

                    /// <summary>
                    /// <para>Indicates whether quick event handling is selected by default. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>2: Quick event handling is selected.</description></item>
                    /// <item><description>1: Quick event handling is displayed but not selected.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("OpLevel")]
                    [Validation(Required=false)]
                    public string OpLevel { get; set; }

                    /// <summary>
                    /// <para>The playbook parameters and the corresponding properties.</para>
                    /// </summary>
                    [NameInMap("ParamConfig")]
                    [Validation(Required=false)]
                    public List<object> ParamConfig { get; set; }

                    /// <summary>
                    /// <para>The opcode configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;opCode&quot;:&quot;3&quot;}</para>
                    /// </summary>
                    [NameInMap("TaskConfig")]
                    [Validation(Required=false)]
                    public string TaskConfig { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>kill_process_isolate_file</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the playbook is intended for Web Application Firewall (WAF). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("WafPlaybook")]
                    [Validation(Required=false)]
                    public bool? WafPlaybook { get; set; }

                }

                /// <summary>
                /// <para>The IDs of the users who can handle objects.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176618589410****</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
