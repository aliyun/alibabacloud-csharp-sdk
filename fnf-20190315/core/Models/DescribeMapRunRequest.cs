// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeMapRunRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_exec_name</para>
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_flow_name</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c39142f1345b196d678333c41f113200</para>
        /// </summary>
        [NameInMap("MapRunName")]
        [Validation(Required=false)]
        public string MapRunName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3A44E113-9962-5B0B-AB92-14060EFE3164</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
