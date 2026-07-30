// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadLockDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1u5mas9exx7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>Required for PolarDB for MySQL cluster instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp16v3824rt73****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The source of the analysis task:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MANUAL</b> or <b>not specified</b>: queries the recent deadlock analysis task.</para>
        /// </description></item>
        /// <item><description><para><b>AUTO</b>: queries the full deadlock analysis task.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the deadlock text. This value is returned from the GetDeadLockHistory operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a0e390cd5aca9ae964448f040153****</para>
        /// </summary>
        [NameInMap("TextId")]
        [Validation(Required=false)]
        public string TextId { get; set; }

    }

}
