// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDesignProjectFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The information about the schema design process.</para>
        /// </summary>
        [NameInMap("ProjectFlow")]
        [Validation(Required=false)]
        public GetTableDesignProjectFlowResponseBodyProjectFlow ProjectFlow { get; set; }
        public class GetTableDesignProjectFlowResponseBodyProjectFlow : TeaModel {
            /// <summary>
            /// <para>The position of the current node in the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CurrentPosition")]
            [Validation(Required=false)]
            public int? CurrentPosition { get; set; }

            /// <summary>
            /// <para>The nodes in the process.</para>
            /// </summary>
            [NameInMap("FlowNodeArray")]
            [Validation(Required=false)]
            public List<GetTableDesignProjectFlowResponseBodyProjectFlowFlowNodeArray> FlowNodeArray { get; set; }
            public class GetTableDesignProjectFlowResponseBodyProjectFlowFlowNodeArray : TeaModel {
                /// <summary>
                /// <para>Indicates whether the ticket can be returned to the schema design node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The ticket can be returned to the schema design node.</description></item>
                /// <item><description><b>0</b>: The ticket cannot be returned to the schema design node. This value can be returned only for the PUBLISH node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BackToDesign")]
                [Validation(Required=false)]
                public bool? BackToDesign { get; set; }

                /// <summary>
                /// <para>Indicates whether the current node can be skipped. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The current node can be skipped.</description></item>
                /// <item><description><b>0</b>: The current node cannot be skipped. This value can be returned only for the PUBLISH node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// <para>The role of the node in the process.</para>
                /// <list type="bullet">
                /// <item><description>START: The ticket was created.</description></item>
                /// <item><description>DESIGN: The schema is being created.</description></item>
                /// <item><description>PUBLISH: The schema is published.</description></item>
                /// <item><description>END: The ticket is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DESIGN</para>
                /// </summary>
                [NameInMap("NodeRole")]
                [Validation(Required=false)]
                public string NodeRole { get; set; }

                /// <summary>
                /// <para>The title of the node.</para>
                /// </summary>
                [NameInMap("NodeTitle")]
                [Validation(Required=false)]
                public string NodeTitle { get; set; }

                /// <summary>
                /// <para>The position of the node in the process. The value starts from 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is the anchor node. A schema design process has only one anchor node, on which the schema is published. After the schema is published on the anchor node, a post-publish image is generated and the DDL metadata lock is released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("PublishAnchor")]
                [Validation(Required=false)]
                public bool? PublishAnchor { get; set; }

                /// <summary>
                /// <para>The available publishing strategies.</para>
                /// </summary>
                [NameInMap("PublishStrategies")]
                [Validation(Required=false)]
                public List<string> PublishStrategies { get; set; }

            }

            /// <summary>
            /// <para>The description of the security rule set that is applied to the schema design ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysq_test</para>
            /// </summary>
            [NameInMap("RuleComment")]
            [Validation(Required=false)]
            public string RuleComment { get; set; }

            /// <summary>
            /// <para>The name of the security rule set that is applied to the schema design ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql default</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the request ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5FD0BC8-2D90-4478-B8EC-A0E92E0B1773</para>
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

    }

}
