// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetClusterInterceptionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster. Separate multiple cluster IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListClusterInterceptionConfig~~">ListClusterInterceptionConfig</a> operation to query the IDs of clusters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c60b77fe62093480db6164a3c2fa****</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to turn on the switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SwitchOn")]
        [Validation(Required=false)]
        public int? SwitchOn { get; set; }

        /// <summary>
        /// <para>The type of the switch that you want to configure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the interception switch</description></item>
        /// <item><description><b>1</b>: the interception type switch</description></item>
        /// <item><description><b>2</b>: the interception history switch</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public int? SwitchType { get; set; }

    }

}
