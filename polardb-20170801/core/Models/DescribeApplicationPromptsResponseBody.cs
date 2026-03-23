// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationPromptsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeApplicationPromptsResponseBodyItems> Items { get; set; }
        public class DescribeApplicationPromptsResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>prompt if enabled</para>
            /// </summary>
            [NameInMap("PromptEnabled")]
            [Validation(Required=false)]
            public int? PromptEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>papt-58z96zl691otf356o4</para>
            /// </summary>
            [NameInMap("PromptId")]
            [Validation(Required=false)]
            public string PromptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prompt name</para>
            /// </summary>
            [NameInMap("PromptName")]
            [Validation(Required=false)]
            public string PromptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DELETE_RELATIONS_SYSTEM_PROMPT</para>
            /// </summary>
            [NameInMap("PromptType")]
            [Validation(Required=false)]
            public string PromptType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prompt value</para>
            /// </summary>
            [NameInMap("PromptValue")]
            [Validation(Required=false)]
            public string PromptValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
