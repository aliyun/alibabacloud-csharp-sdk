// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateDigitalEmployeeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("defaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("knowledges")]
        [Validation(Required=false)]
        public UpdateDigitalEmployeeRequestKnowledges Knowledges { get; set; }
        public class UpdateDigitalEmployeeRequestKnowledges : TeaModel {
            [NameInMap("bailian")]
            [Validation(Required=false)]
            public List<UpdateDigitalEmployeeRequestKnowledgesBailian> Bailian { get; set; }
            public class UpdateDigitalEmployeeRequestKnowledgesBailian : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>index-xxxx</para>
                /// </summary>
                [NameInMap("indexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>llm-xxxx</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            [NameInMap("sop")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Sop { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::12345678912:role/testrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
