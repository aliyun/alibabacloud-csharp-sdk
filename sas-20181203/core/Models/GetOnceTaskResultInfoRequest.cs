// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOnceTaskResultInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scan task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9dfa3a7eb9547781632785b49003****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The name of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: a task of the Security Center agent</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: an O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: a task of asset information collection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSETS_COLLECTION</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: a task of the Security Center agent</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: an O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: a task of asset information collection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSETS_COLLECTION</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
