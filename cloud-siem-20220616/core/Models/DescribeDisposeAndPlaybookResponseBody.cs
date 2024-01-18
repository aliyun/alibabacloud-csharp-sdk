// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDisposeAndPlaybookResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDisposeAndPlaybookResponseBodyData Data { get; set; }
        public class DescribeDisposeAndPlaybookResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeDisposeAndPlaybookResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeDisposeAndPlaybookResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The current page number.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The detailed data
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeDisposeAndPlaybookResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeDisposeAndPlaybookResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The number of alerts that are associated with the entity.
                /// </summary>
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                /// <summary>
                /// The object for handling.
                /// </summary>
                [NameInMap("Dispose")]
                [Validation(Required=false)]
                public string Dispose { get; set; }

                /// <summary>
                /// The entity ID
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// The entity information.
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EntityInfo { get; set; }

                /// <summary>
                /// The key-value pairs each of which consists of opcode and oplevel.
                /// </summary>
                [NameInMap("OpcodeMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> OpcodeMap { get; set; }

                /// <summary>
                /// An array consisting of the codes of playbooks that are recommended for entity handling.
                /// </summary>
                [NameInMap("OpcodeSet")]
                [Validation(Required=false)]
                public List<string> OpcodeSet { get; set; }

                /// <summary>
                /// The playbooks that can handle the entity.
                /// </summary>
                [NameInMap("PlaybookList")]
                [Validation(Required=false)]
                public List<DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList> PlaybookList { get; set; }
                public class DescribeDisposeAndPlaybookResponseBodyDataResponseDataPlaybookList : TeaModel {
                    /// <summary>
                    /// The playbook description.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The display name of the playbook.
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// The playbook name, which is the unique identifier of the playbook.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The opcode of the playbook, which corresponds to the opcode of the playbook recommended for entity handling.
                    /// </summary>
                    [NameInMap("OpCode")]
                    [Validation(Required=false)]
                    public string OpCode { get; set; }

                    /// <summary>
                    /// Indicates whether quick event handling is selected by default. Valid values:
                    /// 
                    /// *   2: Quick event handling is selected.
                    /// *   1: Quick event handling is displayed but not selected.
                    /// </summary>
                    [NameInMap("OpLevel")]
                    [Validation(Required=false)]
                    public string OpLevel { get; set; }

                    [NameInMap("ParamConfig")]
                    [Validation(Required=false)]
                    public List<object> ParamConfig { get; set; }

                    /// <summary>
                    /// The opcode configuration.
                    /// </summary>
                    [NameInMap("TaskConfig")]
                    [Validation(Required=false)]
                    public string TaskConfig { get; set; }

                    /// <summary>
                    /// Indicates whether the playbook is intended for Web Application Firewall (WAF). Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("WafPlaybook")]
                    [Validation(Required=false)]
                    public bool? WafPlaybook { get; set; }

                }

                /// <summary>
                /// An array consisting of the IDs of the users who can handle objects.
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
