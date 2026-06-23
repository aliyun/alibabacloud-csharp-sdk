// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProcessDefinitionsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the process definition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MaxCompute</para>
        /// </description></item>
        /// <item><description><para>DataService</para>
        /// </description></item>
        /// <item><description><para>Extension</para>
        /// </description></item>
        /// <item><description><para>Hologres</para>
        /// </description></item>
        /// <item><description><para>EMR (You cannot create custom definitions for this type.)</para>
        /// </description></item>
        /// <item><description><para>DataAssetGovernance (You cannot create custom definitions for this type.)</para>
        /// </description></item>
        /// <item><description><para>Lindorm (You cannot create custom definitions for this type.)</para>
        /// </description></item>
        /// <item><description><para>DlfNext (You cannot create custom definitions for this type.)</para>
        /// </description></item>
        /// <item><description><para>DlfV1 (You cannot create custom definitions for this type.)</para>
        /// </description></item>
        /// <item><description><para>StarRocks (You cannot create custom definitions for this type.)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
