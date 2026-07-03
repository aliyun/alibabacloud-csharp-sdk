// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDisposeAndPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
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
                /// <para>The number of entries returned per page.</para>
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
                /// <para>The number of alerts that are associated with the entity.</para>
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
                /// <para>The ID of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345****</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The information about the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;file_path&quot;: &quot;c:/www/leixi.jsp&quot;,&quot;file_hash&quot;: &quot;aa0ca926ad948cd820e0a3d9a18c****&quot;,&quot;host_uuid&quot;: &quot;efed2cf7-0b77-45d9-a97b-d2cf246b****&quot;,&quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.webshell}&quot;,&quot;host_name&quot;: &quot;launch-advisor-2023****&quot;}</para>
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EntityInfo { get; set; }

                /// <summary>
                /// <para>The type of the entity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ip</c>: IP address</para>
                /// </description></item>
                /// <item><description><para><c>domain</c>: Domain name</para>
                /// </description></item>
                /// <item><description><para><c>url</c>: URL</para>
                /// </description></item>
                /// <item><description><para><c>process</c>: Process</para>
                /// </description></item>
                /// <item><description><para><c>file</c>: File</para>
                /// </description></item>
                /// <item><description><para><c>host</c>: Host</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The opcode and the corresponding operation level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("OpcodeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> OpcodeMap { get; set; }

                /// <summary>
                /// <para>The recommended playbook opcode for the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[1,3]</para>
                /// </summary>
                [NameInMap("OpcodeSet")]
                [Validation(Required=false)]
                public List<string> OpcodeSet { get; set; }

                /// <summary>
                /// <para>The list of playbooks that can be used to handle the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;:&quot;云安全中心-云服务器安全&quot;,&quot;code&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("PlaybookList")]
                [Validation(Required=false)]
                public List<DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList> PlaybookList { get; set; }
                public class DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the playbook is available.</para>
                    /// <list type="bullet">
                    /// <item><description><para>1: available</para>
                    /// </description></item>
                    /// <item><description><para>0: unavailable</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Available")]
                    [Validation(Required=false)]
                    public string Available { get; set; }

                    /// <summary>
                    /// <para>The description of the playbook.</para>
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
                    /// <para>The name of the playbook, which is the unique identifier of the playbook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kill_process_isolate_file</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The opcode of the playbook. The value corresponds to the recommended playbook opcode of the entity.</para>
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
                    /// <item><description><para>2: selected</para>
                    /// </description></item>
                    /// <item><description><para>1: displayed but not selected</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("OpLevel")]
                    [Validation(Required=false)]
                    public string OpLevel { get; set; }

                    /// <summary>
                    /// <para>The list of parameters for the playbook and the attributes of the parameters.</para>
                    /// </summary>
                    [NameInMap("ParamConfig")]
                    [Validation(Required=false)]
                    public List<object> ParamConfig { get; set; }

                    /// <summary>
                    /// <para>The configuration of the opcode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;opCode&quot;:&quot;3&quot;}</para>
                    /// </summary>
                    [NameInMap("TaskConfig")]
                    [Validation(Required=false)]
                    public string TaskConfig { get; set; }

                    /// <summary>
                    /// <para>The reason why the playbook is unavailable.</para>
                    /// <list type="bullet">
                    /// <item><description><para>PARAM_INVALID: The input parameters are invalid.</para>
                    /// </description></item>
                    /// <item><description><para>NO_INGESTION: The required service is not integrated.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PARAM_INVALID</para>
                    /// </summary>
                    [NameInMap("UnAvailableCode")]
                    [Validation(Required=false)]
                    public string UnAvailableCode { get; set; }

                    /// <summary>
                    /// <para>The UUID of the playbook, which is the unique identifier of the playbook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kill_process_isolate_file</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the playbook is a WAF playbook. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>true</c>: Yes</para>
                    /// </description></item>
                    /// <item><description><para><c>false</c>: No</para>
                    /// </description></item>
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
                /// <para>The list of user IDs that are authorized to perform the disposition.</para>
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
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
