// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ExecuteManualNodeRequest : TeaModel {
        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: Development environment. </description></item>
        /// <item><description>PROD: Production environment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The request to run a manual task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExecuteCommand")]
        [Validation(Required=false)]
        public ExecuteManualNodeRequestExecuteCommand ExecuteCommand { get; set; }
        public class ExecuteManualNodeRequestExecuteCommand : TeaModel {
            /// <summary>
            /// <para>The end business date, in the YYYY-MM-DD format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-07</para>
            /// </summary>
            [NameInMap("EndBizDate")]
            [Validation(Required=false)]
            public string EndBizDate { get; set; }

            /// <summary>
            /// <para>The workflow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_12132</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The run parameters.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<ExecuteManualNodeRequestExecuteCommandParamList> ParamList { get; set; }
            public class ExecuteManualNodeRequestExecuteCommandParamList : TeaModel {
                /// <summary>
                /// <para>The parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123324</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The start business date, in the YYYY-MM-DD format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-01</para>
            /// </summary>
            [NameInMap("StartBizDate")]
            [Validation(Required=false)]
            public string StartBizDate { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
