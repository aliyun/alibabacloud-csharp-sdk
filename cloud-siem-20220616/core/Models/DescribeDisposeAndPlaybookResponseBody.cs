// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDisposeAndPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
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
                /// <para>The total number of entries.</para>
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
                /// <para>The number of alerts associated with the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                /// <summary>
                /// <para>The disposition object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.<em>.</em></para>
                /// </summary>
                [NameInMap("Dispose")]
                [Validation(Required=false)]
                public string Dispose { get; set; }

                /// <summary>
                /// <para>The entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345****</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The entity information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;file_path&quot;: &quot;c:/www/leixi.jsp&quot;,&quot;file_hash&quot;: &quot;aa0ca926ad948cd820e0a3d9a18c****&quot;,&quot;host_uuid&quot;: &quot;efed2cf7-0b77-45d9-a97b-d2cf246b****&quot;,&quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.webshell}&quot;,&quot;host_name&quot;: &quot;launch-advisor-2023****&quot;}</para>
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EntityInfo { get; set; }

                /// <summary>
                /// <para>The entity type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ip: IP address</description></item>
                /// <item><description>domain: domain name</description></item>
                /// <item><description>url: URL</description></item>
                /// <item><description>process: process</description></item>
                /// <item><description>file: file</description></item>
                /// <item><description>host: host</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The key-value pairs of opcode and oplevel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("OpcodeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> OpcodeMap { get; set; }

                /// <summary>
                /// <para>The recommended playbook opcodes for entity disposition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[1,3]</para>
                /// </summary>
                [NameInMap("OpcodeSet")]
                [Validation(Required=false)]
                public List<string> OpcodeSet { get; set; }

                /// <summary>
                /// <para>The list of playbooks that can dispose of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;:&quot;云安全中心-云服务器安全&quot;,&quot;code&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("PlaybookList")]
                [Validation(Required=false)]
                public List<DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList> PlaybookList { get; set; }
                public class DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the playbook is available. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Available.</description></item>
                    /// <item><description>0: Unavailable.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
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

                    [NameInMap("DisposeStatus")]
                    [Validation(Required=false)]
                    public string DisposeStatus { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

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
                    /// <para>The playbook opcode, which corresponds to the recommended playbook opcode for entity disposition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("OpCode")]
                    [Validation(Required=false)]
                    public string OpCode { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the playbook is selected by default for one-click event disposition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>2: Selected. </description></item>
                    /// <item><description>1: Displayed but not selected.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("OpLevel")]
                    [Validation(Required=false)]
                    public string OpLevel { get; set; }

                    /// <summary>
                    /// <para>The parameter list and corresponding parameter properties of the playbook.</para>
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
                    /// <para>The code that indicates why the playbook is unavailable. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PARAM_INVALID: The input parameters are invalid. </description></item>
                    /// <item><description>NO_INGESTION: The corresponding product is not connected.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PARAM_INVALID</para>
                    /// </summary>
                    [NameInMap("UnAvailableCode")]
                    [Validation(Required=false)]
                    public string UnAvailableCode { get; set; }

                    /// <summary>
                    /// <para>The playbook UUID, which is the unique identifier of the playbook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kill_process_isolate_file</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <para>Indicates whether this is a WAF playbook. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Yes.</description></item>
                    /// <item><description>false: No.</description></item>
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
                /// <para>The disposition scope. The list of user IDs that can perform the disposition.</para>
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
        /// <para>The response message.</para>
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
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
