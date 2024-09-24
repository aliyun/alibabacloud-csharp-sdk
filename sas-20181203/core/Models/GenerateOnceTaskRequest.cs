// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The additional information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:1,&quot;problemType&quot;:&quot;offline&quot;,&quot;uuids&quot;:&quot;inet-795dcad1-360f-49d2-b01e-b7da7f1c****&quot;}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The source of the scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The name of the scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: a client diagnosis task</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: an O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: a task of asset information collection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_PROBLEM_CHECK</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: a client diagnosis task</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: an O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: a task of asset information collection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_PROBLEM_CHECK</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
