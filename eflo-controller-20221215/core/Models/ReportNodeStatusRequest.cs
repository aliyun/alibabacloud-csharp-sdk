// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ReportNodeStatusRequest : TeaModel {
        /// <summary>
        /// <para>The detailed description of the exception.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU 0 reporting XID 79 (fallen off bus)</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The diagnosis type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QUICK: quick diagnosis</description></item>
        /// <item><description>COMPREHENSIVE: comprehensive diagnosis</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPREHENSIVE</para>
        /// </summary>
        [NameInMap("DiagnosisType")]
        [Validation(Required=false)]
        public string DiagnosisType { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-eowpxmsldd</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
