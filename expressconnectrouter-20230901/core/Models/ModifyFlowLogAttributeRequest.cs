// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class ModifyFlowLogAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the flow log.
        /// The description can be empty or 0 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ECR ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-fu8rszhgv7623c****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The ID of the flow log.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flowlog-m5evbtbpt****</para>
        /// </summary>
        [NameInMap("FlowLogId")]
        [Validation(Required=false)]
        public string FlowLogId { get; set; }

        /// <summary>
        /// <para>The new name of the flow log. The name must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The time window for collecting log data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>60</b></description></item>
        /// <item><description><b>600</b></description></item>
        /// </list>
        /// <para>Default value: <b>600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The sampling proportion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1:4096</b></description></item>
        /// <item><description><b>1:2048</b></description></item>
        /// <item><description><b>1:1024</b></description></item>
        /// </list>
        /// <para>Default value: <b>1:4096</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1:4096</para>
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public string SamplingRate { get; set; }

    }

}
