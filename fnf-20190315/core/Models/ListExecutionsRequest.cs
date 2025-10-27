// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The name prefix of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run</para>
        /// </summary>
        [NameInMap("ExecutionNamePrefix")]
        [Validation(Required=false)]
        public string ExecutionNamePrefix { get; set; }

        /// <summary>
        /// <para>The name of the flow. The name must be unique within the region and cannot be modified after the flow is created. The name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The number of executions that you want to query. Valid values: 1-99. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("MapRunName")]
        [Validation(Required=false)]
        public string MapRunName { get; set; }

        [NameInMap("MetadataOnly")]
        [Validation(Required=false)]
        public bool? MetadataOnly { get; set; }

        /// <summary>
        /// <para>The name of the execution to start the query. You can obtain the value from the response data. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow_xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query executions. Specify the value in the UTC RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-02T02:39:20.402Z</para>
        /// </summary>
        [NameInMap("StartedTimeBegin")]
        [Validation(Required=false)]
        public string StartedTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the time range to query executions. Specify the value in the UTC RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-02T02:23:54.817Z</para>
        /// </summary>
        [NameInMap("StartedTimeEnd")]
        [Validation(Required=false)]
        public string StartedTimeEnd { get; set; }

        /// <summary>
        /// <para>The status of the execution that you want to filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Starting</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Stopped</b></description></item>
        /// <item><description><b>Succeeded</b></description></item>
        /// <item><description><b>Failed</b></description></item>
        /// <item><description><b>TimedOut</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
